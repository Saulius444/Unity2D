using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizzard : MonoBehaviour {

	[SerializeField] int maxNum;
	[SerializeField] int minNum;
	[SerializeField] TextMeshProUGUI guessText;
	int guess;

	// Use this for initialization
	void Start () {

		StartGame();
	}

	void StartGame() {

		NextGuess();
	}
	
	public void OnPressHigher() {

		minNum = guess +1;
		NextGuess();
	}

	public void OnPressLower() {

		maxNum = guess -1;
		NextGuess();
	}

	void NextGuess () {

		guess = Random.Range(minNum, maxNum +1);
		guessText.text = guess.ToString();
	}
}
