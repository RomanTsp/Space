using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemycontrollevel5 : MonoBehaviour
{
    GameObject scoreUITextGO;//Посилання на ігровий об’єкт текстового інтерфейсу користувача
    public GameObject ExplosionGO; // prefab вибуха
 

    
    

       


    // Use this for initialization
    void Start()
    {


        //Отримати результат текстy UI
        scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreTextTag");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //Виявленя зіткнення ворожого корабля з кораблем гравця ,або з кулею гравця
        if ((col.tag == "PlayerShipTag") || (col.tag == "PlayerBulletTag"))
        {
            PlayExplosion();
            //Додати 100 очок до рахунку
            scoreUITextGO.GetComponent<GameScore1>().Score += 100;
        

            //Знищити корабель
            Destroy(gameObject);
        }
    }
    //Функція для створення вибуху
    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        //положення вибуху
        explosion.transform.position = transform.position;
    }
}
