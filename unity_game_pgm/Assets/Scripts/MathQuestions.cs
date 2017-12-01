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
	private const int OPER_SIZE = 6;
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
		operators [5] = (char)0x221A; 	// sqaure root / radical symbol
		operIndex = Random.Range(0, OPER_SIZE);
	}

	// TODO We should call this upon every time the player is finished with the question
	// 		maybe have a bool listener in update
	void Start () {
		GenerateMath();
		PrintMath();
		UpdateHint();
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

		float answer = PerformOp (op1, op2);

		// populate answer key with junk, incorrect answer
		for (int i=0; i<SIZE; ++i)
		{
			// gen rand values within a range of 10 of the answer
			if (answer % 1 == 0) { // cast rand vals to int to match real answer
				answers [i] = Random.Range ((int)answer - 10, (int)answer + 10);
			} else { // leave as float
				answers [i] = Random.Range (answer - 10, answer + 10);
			}
			// we are checking that we don't accidentally / magically
			//		generate the right answer! Will likely never enter this while loop, but it's here to be safe
			while (answers[i] == answer) {
				if (answer % 1 == 0) {
					answers [i] = Random.Range ((int)answer - 10, (int)answer + 10);
				} else {
					answers [i] = Random.Range (answer - 10, answer + 10);
				}
			}
		}
		// populate rand arr index with Correct answer
		// 		note: Random.Range(Inclusive val, Exclusive val)
		correctIndex = Random.Range(0, SIZE);
		answers[correctIndex] = answer;
		AnswerCoins [correctIndex].GetComponent<AnswerCoin> ().isCorrect = true;
	}

	private float PerformOp(float a, float b) {
		float temp = 0;
		switch (operIndex)
		{
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
			case 5:
				// for square roots, only op b (op2) will be processed
				temp = Mathf.Sqrt (b);
				break;
		}
		return temp;
	}

	private void PrintMath() {
		// RP 2017-12-1
		// if square root, then diplay only op2
		if (operIndex == 5) {
			mathQuestion.text = "Evaluate: " + operators [operIndex] + op2 + " = ? \n\n" +
			"(A) ";
		} else {
			mathQuestion.text = "Evaluate: " + op1 + " " + operators [operIndex] + " " + op2 + " = ? \n\n" +
			"(A) ";
		}

		if (operIndex == 2) { // if performing division, convert to fraction
			Fraction newFraction = Fraction.Parse ((double)answers [0]);
			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;
		} else {
			mathQuestion.text += answers [0];
		}

		mathQuestion.text += " (B) ";
		if (operIndex == 2) { // if performing division, convert to fraction
			Fraction newFraction = Fraction.Parse ((double)answers [1]);
			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;
		} else {
			mathQuestion.text += answers [1];
		}

		mathQuestion.text += " (C) ";
		if (operIndex == 2) { // if performing division, convert to fraction
			Fraction newFraction = Fraction.Parse ((double)answers [2]);
			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;
		} else {
			mathQuestion.text += answers [2];
		}

		mathQuestion.text += " (D) ";
		if (operIndex == 2) { // if performing division, convert to fraction
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
		public Fraction(int numerator, int denominator) {
			this.Numerator = numerator;
			this.Denominator = denominator;
		}

		/// <summary>
		/// Approximates a fraction from the provided double
		/// </summary>
		public static Fraction Parse(double d) {
			return ApproximateFraction(d);
		}

		/// <summary>
		/// Returns this fraction expressed as a double, rounded to the specified number of decimal places.
		/// Returns double.NaN if denominator is zero
		/// </summary>
		public double ToDouble(int decimalPlaces) {
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
				if (fraction < value) {
					n++;
				} else {
					d++;
					n = (int)System.Math.Round(value * d);
				}

				fraction = n / (double)d;
			}
			return new Fraction(n, d);
		}
	}

	public void UpdateHint()
	{
		string temp = "";
		switch (operIndex)
		{
		case 0:	// +
			temp = "Use your addition powers! \n\n Try adding the largest left-most values first. \n 910 + 300... do 900 + 300 first, which equals 1200 then add remaining 10!\n\n" +
				"910 + 300 = 1220\n\n" +
				"Another method uses rounding: \n" +
				"Here is an example: 644 + 238\n\nThese numbers are hard to do in your head, so let's make them more manageable.\n" +
				"644 becomes 650 and 238 becomes 240.\n\nAdd 650 and 240 together... ...890 easy right?\n\n" +
				"Now simply subtract what you rounded off. 650 – 644 = 6 and 240 – 238 = 2\n" +
				"6 + 2 = 8. 890 – 8 = 882\n\nThere's your answer!\n" +
				"644 +238 = 882";

			break;
		case 1:	// -
			temp = "If number you're subtracting from is smaller (say 2 - 10), simply make the answer -10 and add back 2... 2 - 10 = -8! FLIP and add!\n\n" +
				"When subtracting from 1,000...\nHere’s a basic rule to subtract a large number from 1,000: Subtract every number except the last from 9 and subtract the final number from 10\n\nFor example:\n1,000 – 556\n\n" +
				"Step 1: Subtract 5 from 9 = 4\n\nStep 2: Subtract 5 from 9 = 4\n\nStep 3: Subtract 6 from 10 = 4\n\nThe answer is 444.";

			break;
		case 2:	// /
			temp = "Division tricks\n\nHere’s a quick way to know when a number can be evenly divided by these certain numbers:\n\n" +
				"10 if the number ends in 0\n9 when the digits are added together and the total is evenly divisible by 9\n8 if the last three digits are evenly divisible by 8 or are 000\n" +
				"6 if it is an even number and when the digits are added together the answer is evenly divisible by 3\n5 if it ends in a 0 or 5\n4 if it ends in 00 or a two digit number that" +
				"is evenly divisible by 4\n3 when the digits are added together and the result is evenly divisible by the number 3\n2 if it ends in 0, 2, 4, 6, or 8";

			break;
		case 3:	// *
			temp = "Every multiplication has a twin, which may be easier to remember.\nFor example if you forget 8×2, you might remember 2×8=16. This way, you only have to remember half the table!\n\n\n" +
				"Another trick is to use base 10, base 20 or base 50.\n" +
				"Base 10 Example: 15 * 13    So, 15 is 5 above 10 and 13 is 3 above 10.\n" +
				"+5     +3\n" +
				"15  *  13\n" +
				"Now, cross add the numbers, like this (either way works) 5 + 13 = 18 OR 3 + 15 = 18. Both equal 18, so let's hold on to that number and make it 180 since we're working with base 10: 180\n" +
				"Next step is to multiply the top two delta values 5 * 3 which equals 15 and add it to 180!\n" +
				"180 + 15 = 195!\n\n\n" +
				"2\nadd the number to itself (in other words, double it) \nExample 2×9 = 9+9 = 18\n\n" +
				"4\ndouble, then double again \nExample 4×9: double 9 is 18, double 18 is 36\n\n" +
				"5\nCut in half, then times 10\nExample: 5x6: Cut 6 in half to get 3, then times 10 for 30\nOr times 10 then cut in half\nExample: 5x9: 9 times 10 is 90, " +
				"then cut in half for 45\nAlso the last digit goes 5, 0, 5, 0, ... like this: 5, 10, 15, 20, ...\n\n" +
				"6\nwhen you multiply 6 by an even number, they both end in the same digit. \nExamples: 6×2=12, 6×4=24, 6×6=36, etc\n\n" +
				"7x8\nThink '5,6,7,8': 56=7×8!\n\n" +
				"8\nDouble, double, double!\nExample: 8×6: double 6 is 12, double 12 is 24, double 24 is 48\n\n" +
				"9\nis 10× the number minus the number. \nExample: 9×6 = 10×6−6 = 60−6 = 54\nthe ones digit goes 9, 8, 7, 6, ...: 9, 18, 27, 36, 45, ...\n" +
				"the tens digit goes  0, 1, 2, 3, ...: 9, 18, 27, 36, 45, ...\nsubtract one to get the tens digit, and the tens and ones digit together make 9\n" +
				"Example: 9×5: tens digit is 4, 4 and 5 make 9, so 45\nExample: 9×8: tens digit is 7, 7 and 2 make 9, so 72\nfingers multiply 9\n" +
				"your hands can help! Example: to multiply 9 by 8, hold your 8th finger down, and count '7' and '2', the answer is 72\n\n" +
				"10\nput a zero after it \nExample: 10×2 = 20\n\n" +
				"11\nup to 11x9: just repeat the digit. Example: 11x4 = 44\nfor 11×10 to 11×18: write the sum of the digits between the digits \nExample: 11×15 = 1(1+5)5 = 165\n" +
				"Note: this works for any two-digit number, but when the sum of the digits is more than 9, we need to'carry the one'. Example: 11×75 = 7(7+5)5 = 7(12)5 = 825.\n\n" +
				"12\nis 10× plus 2×\nExample: 12×4 = 40+8 = 48\n\n" +
				"15\nmultiply by 10, then add half again\nExample: 15×4 = 40+20 = 60\nExample: 15×9 = 90+45 = 135\n\n" +
				"20\nmultiply by 10, then double\nExample: 20×4 = 40+40 = 80\nExample: 20×7 = 70+70 = 140\n\n\n";

			break;
		case 4:	// %
			temp = "What is the % symbol? It's modulus! Divide first and any remainder is your answer!\n\n" +
				"In computing, the modulo operation finds the remainder after division of one number by another (sometimes called modulus). Given two positive numbers, a (the dividend) and n (the divisor), " +
				"a modulo n (abbreviated as a mod n) is the remainder of the Euclidean division of a by n.\n\n";
				
			break;
		case 5:	// sqaure root / radical symbol
			temp = "In mathematics, a square root of a number a is a number y such that y² = a, in other words, a number y whose square (the result of multiplying the number by itself, or y * y) is a. \n\n " +
				"For example, 4 and -4 are square roots of 16 because 4² = (-4)² = 16.Every non-negative real number a has a unique non-negative square root, called the principal square root, which is denoted by √a, where √ is called the radical sign or radix. \n\n" +
				" For example, the principal square root of 9 is 3, denoted √9 = 3, because 32 = 3 ^ 3 = 9 and 3 is non-negative. The term whose root is being considered is known as the radicand. The radicand is the number or expression underneath the radical sign, " +
				"in this example 9.The justification for taking out the square root of any number is this theorem to help simplify √a*b = √a * √b. The square root of a number is equal to the number of the square roots of each factor.";
			break;
		}
		hintText.text = temp;
	}
}