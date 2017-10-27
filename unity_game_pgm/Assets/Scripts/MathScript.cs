using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathScript : MonoBehaviour {

	private string problem; // problem
	private string pType; // problem type
	private string answer; // answer

	private Text text; //attached to Problem object

	private Text[] texts; //attached to Coin objects

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
		//default problem, problem type, answer values
		problem = "6 x 7";
		answer = "42";
		pType = "Multiplication";

		texts = gameObject.GetComponentsInChildren<Text>();
		// randomly selects which object is to be the answer coin
		System.Random rnd = new System.Random ();
		int num = rnd.Next (0, texts.Length);
		if (texts [num].tag != "Problem") {
			texts [num].tag = "Answer";
		}

		//sets text for problem tags
		if (gameObject.tag == "Problem")
			text.text = "Math " + pType + " Problem: " + problem + " = ?";

		// sets the text for the coin objects
		// if answer, gives the answer
		foreach (Text t in texts) {
			if (t.tag == "Answer")
				t.text = answer;
		}
	}

	/*
	// Update is called once per frame
	void Update () {
		//sets text for problem tags
		if (gameObject.tag == "Problem")
			text.text = "Math " + pType + " Problem: " + problem + " = ?";

		// sets the text for the coin objects
		// if answer, gives the answer
		foreach (Text t in texts) {
			if (t.tag == "Answer")
				t.text = answer;
		}
	}*/
}
