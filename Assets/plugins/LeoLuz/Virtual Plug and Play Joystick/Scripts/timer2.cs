using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer2 : MonoBehaviour
{
  
    public GameObject Boss;
    public GameObject timer;
    public GameObject slidet;
    public GameObject enemy;
    public Text myText;

    public int timeletf = 30;
    private float gameTime;

    private void Start()
    {
        
        enemy.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "Boss Fighter " + timeletf + "сек";
        gameTime += 1 * Time.deltaTime;
        if (gameTime >= 1)
        {
            timeletf -= 1;
            gameTime = 0;
        }
        if (timeletf < 10)
        {
            myText.color = Color.red;
        }

        if (timeletf < 0)
        {
            Boss.SetActive(true);
            timer.SetActive(false);
            slidet.SetActive(true);
            Destroy(gameObject);



        }


    }
    }

