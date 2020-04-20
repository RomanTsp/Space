using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class level5_1 : MonoBehaviour
{
    public float time; /* Время в секундах */

    void Start()
    {

    }
    void Update()
    {
        time -= Time.deltaTime; /* Вычитаем из 10 время кадра (оно в миллисекундах) */
        if (time < 0) /* Время вышло пишем */
        {
            SceneManager.LoadScene("level5_1");
        }
    }
}