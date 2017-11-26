using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveHighScore : MonoBehaviour {
	const int HIGH_SCORES = 5;
	const string NAME_KEY = "highScoreName";
	const string SCORE_KEY = "highScore";

	void Update(){
		if (GameManagerJW.Instance.getIsTimerEnd ()) {
			InsertHighScores ();
			GameManagerJW.Instance.resetAllData ();
			SceneManager.LoadScene ("GameEnd");
		}
	}

	public void clearData(){
		PlayerPrefs.DeleteAll();
	}

	void InsertHighScores(){
		string playerName = GameManagerJW.Instance.getUserName ();
		int playerScore = GameManagerJW.Instance.getScore ();

		for (int i = 0; i < HIGH_SCORES; i++) {
			if (!PlayerPrefs.HasKey (SCORE_KEY + i)) {
				PlayerPrefs.SetString (NAME_KEY + i, playerName);
				PlayerPrefs.SetInt (SCORE_KEY + i, playerScore);
				return;
			}  

			int currentScore = PlayerPrefs.GetInt (SCORE_KEY + i);
			if (playerScore > currentScore) {
				string currentName = PlayerPrefs.GetString (NAME_KEY + i);

				PlayerPrefs.SetInt (SCORE_KEY + i, playerScore);
				PlayerPrefs.SetString (NAME_KEY + i, playerName);

				playerScore = currentScore;
				playerName = currentName;
			}
		}
	}

	void DisplayHighScores(){
		for (int i = 0; i < HIGH_SCORES; i++){
			if (PlayerPrefs.HasKey (SCORE_KEY + i)){
				Debug.Log(PlayerPrefs.GetString(NAME_KEY +i) + ", " + PlayerPrefs.GetInt(SCORE_KEY + i));
			}
		}
	}
}