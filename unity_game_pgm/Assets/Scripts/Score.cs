using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 Data: 2017/10/29
 Author: Jun
*/

// RP 2017-11-20 thanks Jun, this is great, I will reuse this to make a new Score script titled ScoreVer2.cs


/*
Modified Data: 2017/11/13
BY: Jun
*/
public class Score : MonoBehaviour {
	public Text scoreText;
	public Text RightAnswerText;
	public Text WrongAnswerText;

	void Start(){
		scoreText.text = "Score : " + GameManagerJW.Instance.getScore();
		RightAnswerText.text = "Correct : " + GameManagerJW.Instance.getRightAns();
		WrongAnswerText.text = "Incorrect : " + GameManagerJW.Instance.getWrongAns();
	}
		
	public void IncreaseScore (){
		GameManagerJW.Instance.increaseScore ();
		scoreText.text = "Score : " + GameManagerJW.Instance.getScore();
	}

	public void DoubleScore(){
		if (GameManagerJW.Instance.getScore () > 0) {
			GameManagerJW.Instance.DoubleScore ();
		} else {
			GameManagerJW.Instance.increaseScore (10);
		}

		scoreText.text = "Score : " + GameManagerJW.Instance.getScore();;
		GameManagerJW.Instance.increaseRight ();
		RightAnswerText.text = "Correct : " + GameManagerJW.Instance.getRightAns();
	}

	public void LoseScore(){
		GameManagerJW.Instance.LoseScore ();
		scoreText.text = "Score : " + GameManagerJW.Instance.getScore();
		GameManagerJW.Instance.increaseWrong ();
		WrongAnswerText.text = "Incorrect : " + GameManagerJW.Instance.getWrongAns();
	}

}