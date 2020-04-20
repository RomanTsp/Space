using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upspeed : MonoBehaviour
{
    public GameObject triger;
    public GameObject slider;
    public GameObject boss;
    public GameObject trigerdown;


    void Start()
    {
    
        triger.SetActive(true);
        slider.SetActive(false);
        boss.SetActive(false);
        trigerdown.SetActive(true);

    }
    

    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "upspeed")
        {

            GetComponent<Player1>().moveSpeed += 9 ;
            triger.SetActive(false);
            slider.SetActive(true);
            boss.SetActive(true);


        }
        if (col.gameObject.name == "downspeed")
        {
            GetComponent<Player1>().moveSpeed -= 13;
            trigerdown.SetActive(false);
        }

       
        



    }
}


