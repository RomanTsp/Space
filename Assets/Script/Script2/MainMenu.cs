﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Button level2;
    public Button level2_1;
    public Button level3;
    public Button level4_1;
    public Button level4;
    public Button level5;
    int levelComplete;
    // Use this for initialization
    void Start () {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        level2.interactable = false;
        level2_1.interactable = false;
        level3.interactable = false;
        level4_1.interactable = false;
        level4.interactable = false;
        level5.interactable = false;

        switch (levelComplete)
        {
            case 1:
                level2.interactable = true;
                break;
            case 2:
                level2.interactable = true;
                level2_1.interactable = true;
                break;
            case 3:
                level2.interactable = true;
                level2_1.interactable = true;
                level3.interactable = true;
                //level4_1.interactable = true;
                //level4.interactable = true;
                break;
            case 4:
                level2.interactable = true;
                level2_1.interactable = true;
                level3.interactable = true;
                level4_1.interactable = true;
                break;
            case 5:
                level2.interactable = true;
                level2_1.interactable = true;
                level3.interactable = true;
                level4_1.interactable = true;
                level4.interactable = true;
                level5.interactable = true;

                break;
            //case 6:
            //    level2.interactable = true;
            //    level2_1.interactable = true;
            //    level3.interactable = true;
            //    level4_1.interactable = true;
            //    level4.interactable = true;
            //    level5.interactable = true;

            //    break;
        }
    }
	
    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }
    public void Reset()
    {
        level2.interactable = false;
        level2_1.interactable = false;
        level3.interactable = false;
        level4_1.interactable = false;
        level4.interactable = false;
        level5.interactable = false;
        PlayerPrefs.DeleteAll();
    }
    public void Levl1()
    {
        SceneManager.LoadScene("level1");
    }
    public void Exit()
    {
        Application.Quit();
    }
    
    
}
