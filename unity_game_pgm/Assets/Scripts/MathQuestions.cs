// RP 2017-11-20

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
//using System; 	// using Unity's Random instead
using Random=UnityEngine.Random;

public class MathQuestions : MonoBehaviour {

	public Text mathQuestion;
	public GameObject[] AnswerCoins;

	private int op1;
	private int op2;
	private const int OPER_SIZE = 5;
	private char[] operators = new char[OPER_SIZE];
	private int operIndex;
	// create array to store A,B,C,D answer key
	private const int SIZE = 4;
	private int[] answers = new int[SIZE];

	private int correctIndex;


	void Awake() {
		// create/init array of math operators? [+, -, /, *]
		operators [0] = '+';
		operators [1] = '-';
		operators [2] = '/';
		operators [3] = '*';
		operators [4] = '%';
		operIndex = Random.Range(0, OPER_SIZE);
	}


	public void GenerateMath()
	{
		// generate random values for operands
		// TODO replace 1 and 101 vals with variables dependent on difficulty!
		op1 = Random.Range(1, 101);
		op2 = Random.Range(1, 101);

		// populate answer key with junk, incorrect answer
		for (int i=0; i<SIZE; ++i) {
			// we are checking that we don't accidentally / magically
			//		generate the right answer!
			answers[i] = Random.Range (-1000, 1000);
			while (answers[i] == PerformOp(op1, op2)) {
				answers[i] = Random.Range (-1000, 1000);
			}
		}
		// populate rand arr index with Correct answer
		// 		note: Random.Range(Inclusive val, Exclusive val)
		correctIndex = Random.Range(0, SIZE);
		answers[correctIndex] = PerformOp(op1, op2);
		AnswerCoins [correctIndex].GetComponent<AnswerCoin> ().isCorrect = true;
	}

	private int PerformOp(int a, int b) {
		int temp = 0;
		switch (operIndex) {
			case 0:
				temp = a + b;
				break;
			case 1:
				temp = a - b;
				break;
			case 2:
				temp = a / b;
				break;
			case 3:
				temp = a * b;
				break;
			case 4:
				temp = a % b;
				break;
		}
		return temp;
	}

	private void PrintMath() {
		mathQuestion.text = "Evaluate: " + op1 + " " + operators[operIndex] + " " + op2 + " = ? \n\n" + 
			"(A) " + answers[0] + 
			" (B) " + answers[1] +
			" (C) " + answers[2] +
			" (D) " + answers[3];
	}

	// TODO We should call this upon every time the player is finished with the question
	// 		maybe have a bool listener in update
	void Start () {
		GenerateMath();
		PrintMath ();
	}

	// Update is called once per frame
	void Update () {
		// put if statement with bool listener to trigger question refresh
		if (AnswerCoins[correctIndex] == null) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}