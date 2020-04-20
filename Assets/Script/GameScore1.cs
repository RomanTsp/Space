using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameScore1 : MonoBehaviour
    
{
    public GameObject panel;
    public GameObject player;
    public GameObject enemy;
    public GameObject canvas;

    Text scoreTextUI;

    int score;
    
    public int Score
    {
        get
        {
            return this.score;
        }
        set
        {
            this.score = value;
            UpdateScoreTextUI();
        }
    }
    
    void Start ()
    {
        //отримати текстовий компонент UI цього ігрового об'єкта
        scoreTextUI = GetComponent<Text>();
        panel.SetActive(false);
    }

    //Функція для оновлення інтерфейсу  тексту UI
    void UpdateScoreTextUI ()
    {
        string scoreStr = string.Format("{0:0000}", score);
        scoreTextUI.text = scoreStr;

        if (score >= 3000) 
            {
            player.SetActive(false);
            enemy.SetActive(false);
            canvas.SetActive(false);
            panel.SetActive(true);

}
	}
}