﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{   //This isn't the script which controlls individual cat movement. Rather, it is the script that chooses a cat to move, and then sends the command to move to a script on the cat object.

    public void ChatMoveCommand(string direction)
    {
        GameObject[] cats;
        int r;

        cats = GameObject.FindGameObjectsWithTag("Cat");
        r = Random.Range(0, cats.Length);

        GameObject selectedCat = cats[r];
        CatMovement MoveMethod = (CatMovement)selectedCat.GetComponent(typeof(CatMovement));
        MoveMethod.Move(direction);
    }
}
