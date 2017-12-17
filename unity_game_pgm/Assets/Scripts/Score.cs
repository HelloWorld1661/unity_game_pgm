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
		if (ScoreType.Type != "O") {
			if (ScoreType.Type == "M") {
				scoreText.text = "Score : $";
			} else {
				scoreText.text = "Score : ";
			}
			scoreText.text += GameManagerJW.Instance.getScore ();
//		scoreText.text = "Score : " + GameManagerJW.Instance.getScore();
			RightAnswerText.text = "Correct : " + GameManagerJW.Instance.getRightAns ();
			WrongAnswerText.text = "Incorrect : " + GameManagerJW.Instance.getWrongAns ();
		} else {
			scoreText.text = "Score : ";
			for (int i = 0; i < GameManagerJW.Instance.getRightAns () - GameManagerJW.Instance.getWrongAns (); i++) {
				GameObject apple = Resources.Load ("Apple") as GameObject;
				Vector3 position = new Vector3 (-7.0F + (i + 1) * 2.0F, -9.0F, 4.0F);
				Instantiate (apple, position, Quaternion.identity);
			}
		}
	}
		
	public void IncreaseScore (){
		GameManagerJW.Instance.increaseScore ();
		if (ScoreType.Type == "M") {
			scoreText.text = "Score : $";
		} else {
			scoreText.text = "Score : ";
		}
		scoreText.text += GameManagerJW.Instance.getScore();
	}

	public void DoubleScore(){
		if (GameManagerJW.Instance.getScore () > 0) {
			GameManagerJW.Instance.DoubleScore ();
		} else {
			GameManagerJW.Instance.increaseScore (10);
		}

		if (ScoreType.Type == "M") {
			scoreText.text = "Score : $";
		} else {
			scoreText.text = "Score : ";
		}
		scoreText.text += GameManagerJW.Instance.getScore();;
		GameManagerJW.Instance.increaseRight ();
		RightAnswerText.text = "Correct : " + GameManagerJW.Instance.getRightAns();
	}

	public void LoseScore(){
		GameManagerJW.Instance.LoseScore ();

		if (ScoreType.Type == "M") {
			scoreText.text = "Score : $";
		} else {
			scoreText.text = "Score : ";
		}
		scoreText.text += GameManagerJW.Instance.getScore();
		GameManagerJW.Instance.increaseWrong ();
		WrongAnswerText.text = "Incorrect : " + GameManagerJW.Instance.getWrongAns();
	}

}