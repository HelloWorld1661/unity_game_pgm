using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionAndAnswerKey : MonoBehaviour {

	public Text[] quesAnsKeys;
	// public List<Text> quesAnsKeys; // or runtime resizeable list

	// Use this for initialization
	void Start() {
//		quesAnsKeys.text = "Score : " + score;	
	}
	
	// Update is called once per frame
	void Update() {
		
	}

	void assignMath() {
		quesAnsKeys[0].text = "6 + 2 = ?    (a) 7 (b) 14 (c) 8 (d) 4";
		quesAnsKeys[1].text = "If x and y are non-negative, simplify  (256x13y14)1/4";
	}
}
