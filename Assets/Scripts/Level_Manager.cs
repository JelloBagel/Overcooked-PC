﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level_Manager : MonoBehaviour {

    public void LoadLevel (string name)
    {
        Debug.Log("Level load requested: " + name);
        SceneManager.LoadScene(name);
    }

    public void QuitRequest ()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
}
