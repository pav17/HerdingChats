﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(string direction)
    {
        Debug.Log("Cat " + gameObject + " moved " + direction + "!");
    }
}