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
	public Text hintText;

	private float op1;
	private float op2;
	private const int OPER_SIZE = 5;
	private char[] operators = new char[OPER_SIZE];
	private int operIndex;
	// create array to store A,B,C,D answer key
	private const int SIZE = 4;
	private float[] answers = new float[SIZE];

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

	// TODO We should call this upon every time the player is finished with the question
	// 		maybe have a bool listener in update
	void Start () {
		GenerateMath();
		PrintMath ();
	}

	// Update is called once per frame
	void Update () {
		// put if statement with listener to trigger question refresh
		// TODO should we refresh in a different way instead of reloading scene? (so player doesn't keep starting from beginning)
		if (AnswerCoins[correctIndex] == null) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
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

	private float PerformOp(float a, float b) {
		float temp = 0;
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
		mathQuestion.text = "Evaluate: " + op1 + " " + operators [operIndex] + " " + op2 + " = ? \n\n" +
		"(A) ";
		// RP 2017-11-27
		// checking decimal, then use Fraction struct to convert to traditional fraction
		if (answers [0] % 1 != 0) {
			Fraction newFraction = Fraction.Parse ((double)answers [0]);
			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;
		} else {
			mathQuestion.text += answers [0];
		}
		mathQuestion.text += " (B) ";
		if (answers [1] % 1 != 0) {
			Fraction newFraction = Fraction.Parse ((double)answers [1]);
			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;
		} else {
			mathQuestion.text += answers [1];
		}
		mathQuestion.text += " (C) ";
		if (answers [2] % 1 != 0) {
			Fraction newFraction = Fraction.Parse ((double)answers [2]);
			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;
		} else {
			mathQuestion.text += answers [2];
		}
		mathQuestion.text += " (D) ";
		if (answers [3] % 1 != 0) {
			Fraction newFraction = Fraction.Parse ((double)answers [3]);
			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;
		} else {
			mathQuestion.text += answers [3];
		}
	}

	/// <summary>
	/// Represents a rational number
	/// </summary>
	public struct Fraction
	{
		public int Numerator;
		public int Denominator;

		/// <summary>
		/// Constructor
		/// </summary>
		public Fraction(int numerator, int denominator)
		{
			this.Numerator = numerator;
			this.Denominator = denominator;
		}

		/// <summary>
		/// Approximates a fraction from the provided double
		/// </summary>
		public static Fraction Parse(double d)
		{
			return ApproximateFraction(d);
		}

		/// <summary>
		/// Returns this fraction expressed as a double, rounded to the specified number of decimal places.
		/// Returns double.NaN if denominator is zero
		/// </summary>
		public double ToDouble(int decimalPlaces)
		{
			if (this.Denominator == 0)
				return double.NaN;

			return System.Math.Round(
				Numerator / (double)Denominator,
				decimalPlaces
			);
		}


		/// <summary>
		/// Approximates the provided value to a fraction.
		/// http://stackoverflow.com/questions/95727/how-to-convert-floats-to-human-readable-fractions
		/// </summary>
		private static Fraction ApproximateFraction(double value)
		{
			const double EPSILON = .000001d;

			int n = 1;  // numerator
			int d = 1;  // denominator
			double fraction = n / d;

			while (System.Math.Abs(fraction - value) > EPSILON)
			{
				if (fraction < value)
				{
					n++;
				}
				else
				{
					d++;
					n = (int)System.Math.Round(value * d);
				}

				fraction = n / (double)d;
			}

			return new Fraction(n, d);
		}
	}
}