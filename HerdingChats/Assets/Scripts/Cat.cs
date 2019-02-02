using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveHorizontal;
    private float moveVertical;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    
    public void Move(string direction)
    {
        Debug.Log("Cat " + gameObject + " moved " + direction + "!");

        if(direction == "Up" || direction == "up")
        {
            moveHorizontal = 0.0f;
            moveVertical = Global.Instance.catMoveForce;
        }
        else if (direction == "Down" || direction == "down")
        {
            moveHorizontal = 0.0f;
            moveVertical = -Global.Instance.catMoveForce;
        }
        else if (direction == "Left" || direction == "left")
        {
            moveHorizontal = -Global.Instance.catMoveForce;
            moveVertical = 0.0f;
        }
        else if (direction == "Right" || direction == "right")
        {
            moveHorizontal = Global.Instance.catMoveForce;
            moveVertical = 0.0f;
        }

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        rb.AddForce(movement);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.CompareTag("Player") == true)
        {
            Global.Instance.catsCought = Global.Instance.catsCought + 1;
            Debug.Log(Global.Instance.catsCought);
            Destroy(gameObject);
        }
    }
}
