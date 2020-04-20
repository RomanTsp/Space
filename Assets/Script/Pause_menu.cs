using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_menu : MonoBehaviour
{
    public GameObject joystick;
    public GameObject button;
    public GameObject buttonFire;
    public GameObject buttonJump;
    public GameObject buttonFire1;
    public GameObject buttonJump1;

    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;
    // Update is called once per frame
    public void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        buttonFire.SetActive(true);
        buttonJump.SetActive(true);
        buttonJump1.SetActive(true);
        buttonFire1.SetActive(true);

    }
    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
         buttonFire.SetActive(false);
        buttonJump.SetActive(false);
        buttonFire1.SetActive(false);
        buttonJump1.SetActive(false);
    }

    public void  QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        
    }
    public void Juystick()
    {
            joystick.SetActive(true);
             button.SetActive(false);
}
    public void Botton()
    {
        joystick.SetActive(false);
        button.SetActive(true);
    }
}

    
    