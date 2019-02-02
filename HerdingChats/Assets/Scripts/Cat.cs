using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveHorizontal;
    private float moveVertical;
    private float catMoveTimer;
    private float catMoveChance;
    private float catMoveDirectionChance;
    private string catMoveDirection;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        catMoveTimer = 0.0f;
        catMoveDirectionChance = Random.Range(Global.Instance.catMoveTimeMin, Global.Instance.catMoveTimeMax);
        catMoveChance = Random.Range(Global.Instance.catMoveTimeMin, Global.Instance.catMoveTimeMax);
    }

    void Update()
    {
        catMoveTimer = catMoveTimer + Time.deltaTime;
        if(catMoveTimer >= catMoveChance)
        {
            MoveDirection();
        }
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

    public void Evade()
    {
        //Will make cats avoid player
    }

    void MoveDirection()
    {
        if (catMoveTimer >= catMoveChance)
        {
            catMoveDirectionChance = Random.Range(1, 100);
            if (catMoveDirectionChance <= 25)
            {
                catMoveDirection = "Up";
            }
            else if (catMoveDirectionChance > 25 && catMoveDirectionChance <= 50)
            {
                catMoveDirection = "Down";
            }
            else if (catMoveDirectionChance > 50 && catMoveDirectionChance <= 75)
            {
                catMoveDirection = "Left";
            }
            else if (catMoveDirectionChance > 75 && catMoveDirectionChance <= 100)
            {
                catMoveDirection = "Right";
            }
            Move(catMoveDirection);
            catMoveChance = Random.Range(Global.Instance.catMoveTimeMin, Global.Instance.catMoveTimeMax);
            catMoveTimer = 0.0f;
        }
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
