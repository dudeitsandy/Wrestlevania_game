﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Application.targetFrameRate = 60;
		
	}
	
	// Update is called once per frame
	public void GoToGame () {
        SceneManager.LoadScene("Game");
	}
}
