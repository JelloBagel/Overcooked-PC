using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose_Timer : MonoBehaviour {

    public float timeLeft; //in seconds
    private Level_Manager _level_Manager;

	// Use this for initialization
	void Start () {
        _level_Manager = GameObject.FindObjectOfType<Level_Manager>();
    }
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            _level_Manager.LoadLevel("Lose");
        }
	}
}
