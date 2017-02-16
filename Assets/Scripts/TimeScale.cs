using UnityEngine;
using System;
using System.IO;
using System.Text;
using System.Collections;
using UnityEngine.EventSystems;

public class TimeScale : MonoBehaviour
{
	private static float saveTimeScale;


	public void Start()
	{
		Time.timeScale = 0;

        Debug.Log("Start -> " + Time.timeScale);
    }


	public void PlayButton()
	{
		//Set TimeScale to 1, regardless of current state
		Time.timeScale = 1.0f;

        Debug.Log("PlayButton -> " + Time.timeScale);
    }


	public void PauseButton()
	{
        //IF game is NOT paused THEN save time and pause game
        if(Time.timeScale != 0)
        {
            saveTimeScale = Time.timeScale;
            Time.timeScale = 0;     
        }

        //ELSE return game time to saved time
        else
        {
            Time.timeScale = saveTimeScale;
        }

        Debug.Log("PauseButton -> " + Time.timeScale);
    }


	public void FastForwardButton()
    {
        //IF timeScale is not 2 THEN double speed to 2
        if(Time.timeScale != 2)
        {
            Time.timeScale = 2; 
        }

        //IF timeScale is 2 THEN restore speed to 1
        else if(Time.timeScale == 2)
        {
            Time.timeScale = 1.0f;

            //Remove highlight from button
            EventSystem.current.SetSelectedGameObject(null);
        }

        Debug.Log("FastForwardButton -> " + Time.timeScale);
    }


    public void ResetTime()
    {
        saveTimeScale = 0;
        Time.timeScale = 0;

        Debug.Log("ResetButton -> " + Time.timeScale);
    }


}
