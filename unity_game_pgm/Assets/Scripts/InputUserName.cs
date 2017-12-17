using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// Required when Using UI elements.
using UnityEngine.SceneManagement;
/*
 Data: 2017/10/29
 Author: Jun
*/

public class InputUserName : MonoBehaviour {
	public InputField PlayerNameInputField;

	// Update is called once per frame
	void Update () {
		savePlayerName ();
	}
		
	public void savePlayerName(){
		GameManagerJW.Instance.setUserName (PlayerNameInputField.text);
	}

	public void enterNameGoToGame(){
		if (PlayerNameInputField.text == "") {
			return;
		} else {
			SceneManager.LoadScene ("firstScene");
			// RP 2017-11-27 this could be put in many other places but I put here to reset scores
			// 		otherwise a new user has previous user's scores
			//		Jun, if you'd like to preserve the scores, the we need to also preserve the playername previously used
			GameManagerJW.Instance.setScore(0);
			GameManagerJW.Instance.setRight(0);
			GameManagerJW.Instance.setWrong(0);
		}
	}
}