﻿// RP 2017-11-20

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
//using System; 	// using Unity's Random instead
using Random=UnityEngine.Random;

public class MathQuestions : MonoBehaviour {

	public Text mathQuestion;
	public GameObject[] AnswerCoins;

	private int op1;
	private int op2;
	// create array to store A,B,C,D answer key
	private const int SIZE = 4;
	private int[] answers = new int[SIZE];

	private int correctIndex;

	// TODO create array of math operators? [+, -, /, *]

	public void StartTheQuiz()
	{
		// generate random values for operands
		// TODO replace 1 and 101 vals with variables dependent on difficulty!
		op1 = Random.Range(1, 101);
		op2 = Random.Range(1, 101);

		// populate answer key with junk, incorrect answer
		for (int i=0; i<SIZE; ++i) {
			// we are checking that we don't accidentally / magically
			//		generate the right answer!
			answers[i] = Random.Range (0, 202);
			while (answers[i] == op1 + op2) {
				answers[i] = Random.Range (0, 202);
			}
		}
		// populate rand arr index with Correct answer
		// 		note: Random.Range(Inclusive val, Exclusive val)
		correctIndex = Random.Range(0, SIZE);
		answers[correctIndex] = op1 + op2;
		AnswerCoins [correctIndex].GetComponent<AnswerCoin> ().isCorrect = true;
	}

	// TODO We should call this upon every time the player is finished with the question
	// 		maybe have a bool listener in update
	void Start () {
		StartTheQuiz ();
		mathQuestion.text = "Evaluate: " + op1 + " + " + op2 + " = ? \n\n" + 
			"(A) " + answers[0] + 
			" (B) " + answers[1] +
			" (C) " + answers[2] +
			" (D) " + answers[3];
	}

	// Update is called once per frame
	void Update () {
		// put if statement with bool listener to trigger question refresh
	}
}