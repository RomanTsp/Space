using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meinacter : MonoBehaviour
{
 

    public float speed;//для швидкості ворога


    // Use this for initialization
    void Start()
    {
        speed = 4f;//задана швидкість


    }

    // Update is called once per frame
    void Update()
    {
        // Поточна позиція противника
        Vector2 position = transform.position;


        // Обчисленя  нової позиції противника
        position = new Vector2(position.x, position.y - speed * Time.deltaTime);

        //Oновлення позиції ворога
        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        //Якщо ворог вийшов за межі екрану , знищити ворога
        if (transform.position.y < min.y)
        {
            Destroy(gameObject);
        }
    }
}