// RP 2017-11-20

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreVer2 : MonoBehaviour {
	private int score = 0;
	private int getRight = 0;
	private int getWrong = 0;

	public Text scoreText;
	public Text RightAnswerText;
	public Text WrongAnswerText;

	void Start () {
		
	}

	void Update () {
		
	}

	public void IncreaseScore (){
		score += 1;
		scoreText.text = "Score : " + score;
	}

	public void DoubleScore(){
		// otherwise, if score is negative, right answer makes it more negative
		if (score > 0) {
			score *= 2;
		} else {
			score += 10;
		}
		scoreText.text = "Score : " + score;
		getRight += 1;
		RightAnswerText.text = "Correct : " + getRight;
	}

	public void LoseScore(){
		score -= 2;
		scoreText.text = "Score : " + score;
		getWrong += 1;
		WrongAnswerText.text = "Incorrect : " + getWrong;
	}
}