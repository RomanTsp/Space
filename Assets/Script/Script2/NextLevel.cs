﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelController.instance.IsEndGame();
    }
}