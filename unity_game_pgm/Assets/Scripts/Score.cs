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
	// RP 2017-12-17
	// to be used for selecting M O N modes
	public Text scoreText;
	public GameObject apple;
	public GameObject cash;

	public Text RightAnswerText;
	public Text WrongAnswerText;

	private string o = "     x ";
	private string m = "   USD : $";
	private string n = "Score : ";

	void Awake() {
		apple.gameObject.SetActive(false);
		cash.gameObject.SetActive(false);
	}

	// RP 2017-12-17
	void Start() {
		if (ScoreType.Type == "O") {
			scoreText.text = o;
			apple.gameObject.SetActive(true);
		} else if (ScoreType.Type == "M") {
			scoreText.text = m;
			cash.gameObject.SetActive(true);
		} else {
			scoreText.text = n;
		}
		scoreText.text += GameManagerJW.Instance.getScore ();
		RightAnswerText.text = "Correct : " + GameManagerJW.Instance.getRightAns ();
		WrongAnswerText.text = "Incorrect : " + GameManagerJW.Instance.getWrongAns ();


		// Christian's code
// 		if (ScoreType.Type != "O") {
// 			if (ScoreType.Type == "M") {
// 				scoreText.text = "Cash : $"; // TODO replace with pic of cash
// 			} else {
// 				scoreText.text = "Score : "; // default number representation
// 			}
// 			scoreText.text += GameManagerJW.Instance.getScore ();
// //		scoreText.text = "Score : " + GameManagerJW.Instance.getScore();

// 			// let's leave these guys as is
// 			RightAnswerText.text = "Correct : " + GameManagerJW.Instance.getRightAns ();
// 			WrongAnswerText.text = "Incorrect : " + GameManagerJW.Instance.getWrongAns ();
// 		} else {
// 			scoreText.text = "Score : "; // TODO replace with pic of apple
// 			for (int i = 0; i < GameManagerJW.Instance.getRightAns () - GameManagerJW.Instance.getWrongAns (); i++) {
// 				GameObject apple = Resources.Load ("Apple") as GameObject;
// 				Vector3 position = new Vector3 (-7.0F + (i + 1) * 2.0F, -9.0F, 4.0F);
// 				Instantiate (apple, position, Quaternion.identity);

// 				// TODO
// 				// I think I'm going to do this differently:
// 				// instantiating here is a bit dangerous,
// 				// we want to make the apple a child of the right parent obj
// 				// create all three versions as objects and simply SetActive to true of false
// 				//		i.e; hide or show
// 			}
// 		}
	}
		
	public void IncreaseScore (){
		GameManagerJW.Instance.increaseScore ();
		if (ScoreType.Type == "O") {
			scoreText.text = o;
		} else if (ScoreType.Type == "M") {
			scoreText.text = m;
		} else {
			scoreText.text = n;
		}
		scoreText.text += GameManagerJW.Instance.getScore();
	}

	public void DoubleScore(){
		if (GameManagerJW.Instance.getScore () > 0) {
			GameManagerJW.Instance.DoubleScore ();
		} else {
			GameManagerJW.Instance.increaseScore (10);
		}

		if (ScoreType.Type == "O") {
			scoreText.text = o;
		} else if (ScoreType.Type == "M") {
			scoreText.text = m;
		} else {
			scoreText.text = n;
		}
		scoreText.text += GameManagerJW.Instance.getScore();;
		GameManagerJW.Instance.increaseRight ();
		RightAnswerText.text = "Correct : " + GameManagerJW.Instance.getRightAns();
	}

	public void LoseScore(){
		GameManagerJW.Instance.LoseScore ();

		if (ScoreType.Type == "O") {
			scoreText.text = o;
		} else if (ScoreType.Type == "M") {
			scoreText.text = m;
		} else {
			scoreText.text = n;
		}
		scoreText.text += GameManagerJW.Instance.getScore();
		GameManagerJW.Instance.increaseWrong ();
		WrongAnswerText.text = "Incorrect : " + GameManagerJW.Instance.getWrongAns();
	}

}