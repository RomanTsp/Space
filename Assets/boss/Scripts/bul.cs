﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bul : MonoBehaviour
{
    AudioSource audioData;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.tag == "Player")
            audioData = GetComponent<AudioSource>();
        audioData.Play(0);
      

    }
}