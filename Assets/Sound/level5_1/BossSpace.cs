using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossSpace : MonoBehaviour {
    public GameObject ExplosionGO;
    public GameObject Explosion;
    public Slider mySlider;
    public GameObject BossAgr1;
    public GameObject BossAgr;
    public GameObject slider;
    public GameObject sliderm;
    public GameObject slidern;




    public int life = 45;

    void Start() {
        //mySlider.value = life;
    }


    void Update() {

        mySlider.value = life;

        if (life <= 0)
        {
            PlayExplosionDeath();
            Destroy(gameObject);
            BossAgr.SetActive(true);
            BossAgr1.SetActive(true);
            sliderm.SetActive(true);
            slidern.SetActive(true);
            slider.SetActive(false);
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

