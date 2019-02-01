using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float moveHorizontal;
    private float moveVertical;

    void start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    public void Move(string direction)
    {
        Debug.Log("Cat " + gameObject + " moved " + direction + "!");

        if(direction == "Up" || direction == "up")
        {
            moveHorizontal = 0.0f;
            moveVertical = 10.0f;
        }
        else if (direction == "Down" || direction == "down")
        {
            moveHorizontal = 0.0f;
            moveVertical = -10.0f;
        }
        else if (direction == "Left" || direction == "left")
        {
            moveHorizontal = -10.0f;
            moveVertical = 0.0f;
        }
        else if (direction == "Right" || direction == "right")
        {
            moveHorizontal = 10.0f;
            moveVertical = 0.0f;
        }

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        
        rb.AddForce(movement);
    }
}
