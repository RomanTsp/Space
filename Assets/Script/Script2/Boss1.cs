using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss1 : MonoBehaviour {

    public GameObject ExplosionGO;
    public GameObject Explosion;
    public Slider mySlider;
    public GameObject next;
  



    public int life = 25;

    void Start()
    {
        //mySlider.value = life;
    }


    void Update()
    {

        mySlider.value = life;
        if (life <= 5)
        {
            next.SetActive(true);
        }

        if (life <= 0)
        {
            PlayExplosionDeath();
            Destroy(GameObject.Find("boss1"));
            Destroy(GameObject.Find("boss2"));
            SceneManager.LoadScene("level3");
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

