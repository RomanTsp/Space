using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playTimer : MonoBehaviour {
    public GameObject Timer;
    public GameObject TimerSlider;
    public GameObject Enemy;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Play()
    {
        Timer.SetActive(true);
        TimerSlider.SetActive(true);
        Enemy.SetActive(true);
    }
}
