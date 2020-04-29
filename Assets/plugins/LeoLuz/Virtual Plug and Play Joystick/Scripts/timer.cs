using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {
    public Text myText;
    public GameObject next;

    public int timeletf = 120;
    private float gameTime;
	
	
	// Update is called once per frame
	void Update () {
        myText.text = "Осталось" + timeletf + "сек";
        gameTime += 1 * Time.deltaTime;
        if (gameTime >= 1)
        {
            timeletf -= 1;
            gameTime = 0;
        }
        if(timeletf < 20)
        {
            myText.color = Color.red;
        }
        if(timeletf < 5)
        {
            next.SetActive(true);
        }
        if (timeletf < 0)
        {
            SceneManager.LoadScene("Level4");
        
        }
       
    }
}
