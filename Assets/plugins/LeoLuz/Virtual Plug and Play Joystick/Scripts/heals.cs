using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class heals : MonoBehaviour
{

    public int health;
    public int numberOfLives;
    

    public Image[] lives;
    public Sprite fullLive;
    public Sprite emptyLive;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health > numberOfLives)//якщо кількість здоровя більше чим максимальна кількість життя то..
        {
            health = numberOfLives;//кількість здоровья не буде перевищувати максимальну кількість здоровья
        }
        for (int i = 0; i < lives.Length; i++)// максимальна кількість життя в гравця 
        {
            if (i < health)
            {
                lives[i].sprite = fullLive;// картники життя повинні відображатися заповненими 
            }
            else
            {
                lives[i].sprite = emptyLive;// при втраті життя картинка змінюється на пусту
            }

            if (i < numberOfLives) //максимально поточне значення життя аби воно не могло бути більше ніж назначено в грі max(5)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }

            if (health <= 0)
            {
                SceneManager.LoadScene("Game over");
            }


        }
        
           
        }

    }

