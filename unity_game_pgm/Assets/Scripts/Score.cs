using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 Data: 2017/10/29
 Author: Jun
*/

public class Score : MonoBehaviour {
	private int score = 0;
	private int getRight = 0;
	private int getWrong = 0;

	public Text scoreText;
	public Text RightAnswerText;
	public Text WrongAnswerText;

	public GameObject coin;
	public GameObject RightCoin;
	public GameObject WrongCoin;

	void Start () {}

	void Update () {}

	public void IncreaseScore(int addend){
		score += addend;
		scoreText.text = "Score : " + score;
	}
		
	public void IncreaseScore (){
		IncreaseScore (1);
		scoreText.text = "Score : " + score;
	}

	public void DoubleScore(){
		score *= 2;
		scoreText.text = "Score : " + score;
		getRight += 1;
		RightAnswerText.text = "Answer Right : " + getRight;
	}

	public void LoseScore(){
		score -= 2;
		scoreText.text = "Score : " + score;
		getWrong += 1;
		WrongAnswerText.text = "Answer Wrong : " + getWrong;
	}

}