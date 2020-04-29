using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class boss2 : MonoBehaviour
{

    public GameObject ExplosionGO;
    public GameObject Explosion;
    public Slider mySlider;
  




    public int life = 15;

    void Start()
    {
        //mySlider.value = life;
    }


    void Update()
    {

        mySlider.value = life;
        if (life <= 0)
        {
            PlayExplosionDeath();
            Destroy(gameObject);
           
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Виявленя зіткнення ворожого корабля з кораблем гравця ,або з кулею гравця
        if ((col.tag == "PlayerShipTag") || (col.tag == "PlayerBulletTag"))
        {

            PlayExplosion();
            life--;




        }
    }
    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        //положення вибуху
        explosion.transform.position = transform.position;
    }
    void PlayExplosionDeath()
    {
        GameObject explosion = (GameObject)Instantiate(Explosion);
        //положення вибуху
        explosion.transform.position = transform.position;
    }

}

