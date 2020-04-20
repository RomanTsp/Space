using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spondCanvas : MonoBehaviour {
    private AudioSource audioSrc;
    private float musisVolume = 1f;//зміна гучності музики 
	
	void Start () {
        audioSrc = GetComponent<AudioSource>(); //отримання інформації з AudioSource

    }
	

	void Update () {
        audioSrc.volume = musisVolume;	 //гучність музики 
	}
    public void SetVolume(float vol) //отримання інформації с Slider к компоненту AudioSource
    {
        musisVolume = vol;
    }
}
