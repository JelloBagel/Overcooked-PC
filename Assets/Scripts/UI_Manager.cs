using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour {

    Lose_Timer timerObject;
    private int timerMin;
    private int timerSec;

    //Win_Score scoreObject;

    // Use this for initialization
    void Start () {
        timerObject = GameObject.FindObjectOfType<Lose_Timer>();
        if (timerObject == null)
        {
            Debug.Log("could not find timer");
        }

        //scoreObject = GameObject.FindObjectOfType<Win_Score>();
        //if (scoreObject == null)
        //{
        //    Debug.Log("could not find timer");
        //}
    }
	
	// Update is called once per frame
	void Update () {
        UpdateTimer();

        //scoreObject.GetComponent<Text>().text = scoreObject.score.ToString();

    }

    private void UpdateTimer()
    {
        timerMin = (int)timerObject.timeLeft / 60;
        if (timerMin >= 1)
        {
            timerSec = (int)timerObject.timeLeft - (timerMin * 60);
        }
        else
        {
            timerSec = (int)timerObject.timeLeft;
        }
        timerObject.GetComponent<Text>().text = timerMin + ":" + timerSec;
    }
}
