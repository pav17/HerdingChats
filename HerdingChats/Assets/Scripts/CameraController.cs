<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject player, background;

    void Start()
    {
        transform.position = new Vector3(background.transform.position.x, background.transform.position.y, 0);
    }

    void Update()
    {

        if (Approximately(transform.position.x, player.transform.position.x, 0.1f))
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, 0);
        }
        if (Approximately(transform.position.y, player.transform.position.y, 0.1f))
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y, 0);
        }

    }

    bool Approximately(float a, float b, float threshold)
    {
        return System.Math.Abs(a - b) <= threshold;
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{

    private Vector3 player;
    private Vector3 topRight;
    private Vector3 topLeft;
    private Vector3 bottomRight;
    private Vector3 bottomLeft;
    private BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        player = Vector3.zero;
        topRight = Camera.main.ViewportToWorldPoint(new Vector3(1.0f, 1.0f, -10.0f));
        topLeft = Camera.main.ViewportToWorldPoint(new Vector3(0.0f, 1.0f, -10.0f));
        bottomRight = Camera.main.ViewportToWorldPoint(new Vector3(1.0f, 0.0f, -10.0f));
        bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0.0f, 0.0f, -10.0f));
        //collider = GetComponentInChildren<BoxCollider2D>();
        //collider.OnRect

    }
    
    /*void LateUpdate()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform.position;
        topRight = Camera.main.ViewportToWorldPoint(new Vector3(1.0f, 1.0f, -10.0f));
        topLeft = Camera.main.ViewportToWorldPoint(new Vector3(0.0f, 1.0f, -10.0f));
        bottomRight = Camera.main.ViewportToWorldPoint(new Vector3(1.0f, 0.0f, -10.0f));
        bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0.0f, 0.0f, -10.0f));
        if (topRight.x < 50.96 && topRight.y < 46.27)
        {
            if(bottomRight.x < 50.96 && bottomRight.y > -6.54)
            {
                if (topLeft.x > -13.64 && topLeft.y < 46.27)
                {
                    if (bottomLeft.x > -13.64 && bottomLeft.y > -6.54)
                    {
                        gameObject.transform.SetPositionAndRotation(player, Quaternion.identity);
                    }
                }
            }
        }
    }*/
}
>>>>>>> 4c0991365ad3c6d4de95587661cec04741ed1d68
