﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsOnFloor;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        IsOnFloor = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        IsOnFloor = false;
    }
}
