using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
//using System;
using Random=UnityEngine.Random;

public class MathQuestions : MonoBehaviour {

	public Text mathQuestion;

	private int addend1;
	private int addend2;
	private int sum = 0;

	public void StartTheQuiz()
	{
		addend1 = Random.Range(1, 101);
		addend2 = Random.Range(1, 101);

		sum = addend1 + addend2;
	}



	// Use this for initialization
	void Start () {
		StartTheQuiz ();
		mathQuestion.text = "Evaluate: " + addend1 + " + " + addend2 + "\n\n" + "Answer: " + sum;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
