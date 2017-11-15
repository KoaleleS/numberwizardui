﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization

	int max;
	int min;
	int guess;

	public Text text;
	public int maxGuessesAllowed;
	public Text guessesLeft;

	void Start ()
	{
		StartGame ();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		maxGuessesAllowed = 16;
		guessesLeft.text = maxGuessesAllowed.ToString();
		NextGuess();

	}

	public void GuessLower (){
		max = guess;
		NextGuess ();
	}

	public void GuessHigher (){
		min = guess;
		NextGuess ();
	}

	void NextGuess (){
		guess = Random.Range (min,max + 2);
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed -1;
		guessesLeft.text = maxGuessesAllowed.ToString();
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
