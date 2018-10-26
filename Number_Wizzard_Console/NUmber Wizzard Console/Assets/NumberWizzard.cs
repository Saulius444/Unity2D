using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizzard : MonoBehaviour {

	int maxNum;
	int minNum;
	int guess;

	// Use this for initialization
	void Start () {

		StartGame();
	}

	void StartGame() {

		maxNum = 1000;
		minNum = 1;
		guess = 500;

		Debug.Log("Welcome to number wizzard game.");
		Debug.Log("Think of a number...");
		Debug.Log("Highest possible number is: " + maxNum);
		Debug.Log("Lowest possible number is: " + minNum);
		Debug.Log("Tell me if your number is higher or lower than: " + guess);
		Debug.Log("Push UP = Higher, Push DOWN = Lower, Push ENTER = Correct");
		maxNum = maxNum + 1;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.UpArrow)) {

			minNum = guess;
			NextGuess();
		}

		else if (Input.GetKeyDown(KeyCode.DownArrow)) {

			maxNum = guess;
			NextGuess();
		}

		else if (Input.GetKeyDown(KeyCode.Return)) {

			Debug.Log("I am a genius.");
			StartGame();
		}
	}

	void NextGuess () {

		guess = (maxNum + minNum) / 2;
		Debug.Log("Is it higher or lower than... " + guess);
	}
}
