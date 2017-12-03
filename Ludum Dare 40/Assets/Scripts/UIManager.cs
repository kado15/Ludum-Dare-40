﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public Text scoreText;
	public int scoreNumber;

	// Use this for initialization
	void Start () {
		scoreNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + scoreNumber;
	}
}
