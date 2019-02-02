using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float moveHorizontal;
    private float moveVertical;
    private float moveForce;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        moveForce = 300.0f;
    }
    
    public void Move(string direction)
    {
        Debug.Log("Cat " + gameObject + " moved " + direction + "!");

        if(direction == "Up" || direction == "up")
        {
            moveHorizontal = 0.0f;
            moveVertical = moveForce;
        }
        else if (direction == "Down" || direction == "down")
        {
            moveHorizontal = 0.0f;
            moveVertical = -moveForce;
        }
        else if (direction == "Left" || direction == "left")
        {
            moveHorizontal = -moveForce;
            moveVertical = 0.0f;
        }
        else if (direction == "Right" || direction == "right")
        {
            moveHorizontal = moveForce;
            moveVertical = 0.0f;
        }

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        rb.AddForce(movement);
    }

    void OnCollisonEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
