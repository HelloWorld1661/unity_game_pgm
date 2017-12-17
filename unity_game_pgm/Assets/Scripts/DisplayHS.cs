using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHS : MonoBehaviour {
	public Text[] nameTexts;
	public Text[] scoreTexts;
	const int HIGH_SCORES = 5;
	const string NAME_KEY = "highScoreName";
	const string SCORE_KEY = "highScore";

	void Update(){
		for (int i = 0; i < HIGH_SCORES; i++){
			if (PlayerPrefs.HasKey (SCORE_KEY + i)){
				nameTexts [i].text = PlayerPrefs.GetString (NAME_KEY + i);
				scoreTexts[i].text = PlayerPrefs.GetInt(SCORE_KEY + i).ToString();
			}
		}

		if (GameManagerJW.Instance.getResetData ()) {
			for (int i = 0; i < HIGH_SCORES; i++) {
				nameTexts [i].text = "Player Name";
				scoreTexts [i].text = "Score";
			}
		}
	}
}