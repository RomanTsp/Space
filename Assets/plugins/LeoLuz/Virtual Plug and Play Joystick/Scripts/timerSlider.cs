using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timerSlider : MonoBehaviour {

    public Slider mySlider;

    public int timeletf = 60;
    private float gameTime;


    // Update is called once per frame
    void Update()
    {
        mySlider.value = timeletf;
         gameTime += 1 * Time.deltaTime;
        if (gameTime >= 1)
        {
            timeletf -= 1;
            gameTime = 0;
        }
       
    }
}
