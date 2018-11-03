using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Score : MonoBehaviour {

    public int score;
    public int scoreGoal;
    private Level_Manager _level_Manager;

    // Use this for initialization
    void Start () {
        score = 0;
        scoreGoal = 100;
        _level_Manager = GameObject.FindObjectOfType<Level_Manager>();
    }
	
	// Update is called once per frame
	void Update () {
        WinCondition();
	}

    private void WinCondition ()
    {
        if (score >= scoreGoal)
        {
            _level_Manager.LoadLevel("Win");
        }
    }

    private void OnCollisionEnter(Collision collision) 
    {
        //Debug.Log("collided with " + collision.gameObject.name);
        score += 20;
    }
}
