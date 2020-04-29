using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorLife : MonoBehaviour
{
    public GameObject ExplosionGO; // prefab вибуха

    int life = 4;
    // Use this for initialization
    void Start()
    {
       
    }
    private void Update()
    {
        if (life <= 0)
        {
            Destroy(gameObject);

        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //Виявленя зіткнення ворожого корабля з кораблем гравця ,або з кулею гравця
        if ((col.tag == "PlayerShipTag") || (col.tag == "PlayerBulletTag"))
        {
            life --;
            PlayExplosion();


        }
    }
    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        //положення вибуху
        explosion.transform.position = transform.position;
    }
}