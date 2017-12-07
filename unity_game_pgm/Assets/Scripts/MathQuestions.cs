// RP 2017-11-20

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
//using System; 	// using Unity's Random instead--if not specified, compiler panics
using Random=UnityEngine.Random;
//using UnityEditor; // for ExpressionEval, but must go in an Editor folder which won't be included in game's build
using B83.ExpressionParser;

public class MathQuestions : MonoBehaviour {

	public Text mathQuestion;
	public GameObject[] AnswerCoins;
	public Text hintText;
	public Text answerText;
	public Button nextButton;

	private float op1;
	private float op2;
	private const int OPER_SIZE = 10; // 7 -> 10
	private char[] operators = new char[OPER_SIZE];
	private int operIndex;
	// create array to store A,B,C,D answer key
	private const int SIZE = 4;
	private float[] answers = new float[SIZE];
	private int correctIndex;
	private float answer = 0;

	//	private ExpressionParser parser = new ExpressionParser();

	/* STEPS: Christian & RP
	CHECK!	1) run GenerateMath() several times and concat / store in string fullProblem
	CHECK!	2) parse fullProblem with breakProblem(fullProblem) and store the return type List<string> in say parsedProblem
	CHECK!	3) create function to go through parsedProblem and display chunk 1
	CHECK!	4) pass chunk 1 into math func to get answer & populate answerCoins / preserve coin logic
	CHECK!	5a) if player gets it wrong or dies, problem persists (this is important b/c we must make this data persistent, i.e; put in GameManagerJW.cs)
	CHECK!	(side note TODO, when assigning rand vals to op1 and op2 in GenerateMath(), let's let user define the number range i.e; difficulty in settings... again, this would simply go in GameManagerJW.cs)
		5b) If player gets chunk 1 right, display answer_of_chunk_1 + chunk 2
	6) upon completion of fullProblem, goto step 1

	(maybe create a "next" button to goto step 1 and gen new fullProblem)
	*/


	void Awake()
	{
		// create/init array of math operators? [+, -, /, *]
		operators [0] = '+';
		operators [1] = '-';
		operators [2] = '/';
		operators [3] = '*';
		operators [4] = '^';
		operators [5] = (char)0x221A; 	// sqaure root / radical symbol
		operators [6] = '%';

		//		operators [7] = "sin";
		//		operators [8] = "cos";
		//		operators [9] = "tan";



		answerText.gameObject.SetActive (false);
	}

	void Start ()
	{
		if (GameManagerJW.Instance.isQuestionStarted == false) {
			Refresh ();
		} else {
			ReadParsedProblem (GameManagerJW.Instance.parsedProblem, GameManagerJW.Instance.chunkIndex);
		}
	}

	void Update ()
	{
		if (AnswerCoins[correctIndex] == null) {
			// update chunkIndex for next call
			GameManagerJW.Instance.chunkIndex++;
			// calling in Start()
			//			ReadParsedProblem (GameManagerJW.Instance.parsedProblem, GameManagerJW.Instance.chunkIndex);
			// reloading scene to respawn coins
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	public void Refresh() {
		GenFullProblem ();
		GameManagerJW.Instance.isQuestionStarted = true;
		GameManagerJW.Instance.parsedProblem = breakProblem (GameManagerJW.Instance.fullProblem);
		//		// ReadParsedProblem(string, int) calls PopulateAnswers (string expression]) and PrintAnswerKey (string expression) internally
		ReadParsedProblem (GameManagerJW.Instance.parsedProblem, GameManagerJW.Instance.chunkIndex);
	}

	public void RefreshScene() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	// RP 2017-12-4
	public void Delay (){
		// Disable button here
		nextButton.gameObject.SetActive (false);
		StartCoroutine (Reactivate());
	}

	IEnumerator Reactivate (){
		yield return new WaitForSeconds (0.5f);
		// Re-enable button here
		nextButton.gameObject.SetActive (true);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	// Christian's TRIM VERSION (based on RP original)
	private void GenFullProblem()
	{
		// Reset fullProblem
		GameManagerJW.Instance.fullProblem = "";
		GameManagerJW.Instance.chunkIndex = 0;
		// needed for breakProblem() to work
		GameManagerJW.Instance.fullProblem += " ";

		// % or Sqrt -----------------------------------------------------------------------------------
		op1 = Random.Range (GameManagerJW.Instance.getMinRand (), GameManagerJW.Instance.getMaxRand ());
		op2 = Random.Range (GameManagerJW.Instance.getMinRand (), GameManagerJW.Instance.getMaxRand ());
		int probOfSqrtOrMod = Random.Range (0, 3);
		int operIndex = Random.Range (0, OPER_SIZE);
		if ( (operIndex >= 5) && probOfSqrtOrMod == 1) {
			// Square roots
			if (operIndex == 5) {
				// we don't want negative vals here
				op2 = Mathf.Abs (op2);
//				GameManagerJW.Instance.fullProblem += operators [operIndex] + " " + op2;
				GameManagerJW.Instance.fullProblem += "sqrt(" + " " + op2 + " )";
			}
			// Modulus
			else if (operIndex == 6) {
				// we don't want negative vals here
				op1 = Mathf.Abs (op1);
				op2 = Mathf.Abs (op2);
				GameManagerJW.Instance.fullProblem += op1 + " " + operators [operIndex] + " " + op2;
			} else if(operIndex == 7) {
				op2 = Random.Range (0, 361);
				GameManagerJW.Instance.fullProblem += "sin(" + op2 + "*PI/180)";
			} else if(operIndex == 8) {
				op2 = Random.Range (0, 361);
				GameManagerJW.Instance.fullProblem += "cos(" + op2 + "*PI/180)";
			} else if(operIndex == 9) {
				op2 = Random.Range (0, 361);
				GameManagerJW.Instance.fullProblem += "tan(" + op2 + "*PI/180)";
			}
			GameManagerJW.Instance.fullProblem += " ";
			//			Debug.Log ("FULL PROB: " + GameManagerJW.Instance.fullProblem);
			return;
		}
		// ---------------------------------------------------------------------------------------------

		int x = Random.Range(1, 3);
		for (int i = 0; i < x; i++)
		{
			if (x != 1)
				GameManagerJW.Instance.fullProblem += "[";

			int y = Random.Range(1, 4);
			for (int j = 0; j < y; j++)
			{
				// generate random values for operands
				op1 = Random.Range (GameManagerJW.Instance.getMinRand (), GameManagerJW.Instance.getMaxRand ());
				op2 = Random.Range (GameManagerJW.Instance.getMinRand (), GameManagerJW.Instance.getMaxRand ());
				operIndex = Random.Range (0, 5); // includes ^

				// Christian's suggestion to avoid simpleft form fraction from being displayed
				if (operIndex == 2) {
					int z = Random.Range (2, 5);
					op1 *= z;
					op2 *= z;
				}

				// bug fix (B83 can't handle op2 being negative)
				//				op2 = Mathf.Abs(op2);
				if (op2 < 0) {
					if (y != 1) {
						GameManagerJW.Instance.fullProblem += "[" + op1 + " " + operators [operIndex] + " (" + op2 + ")]";
					} else {
						GameManagerJW.Instance.fullProblem += op1 + " " + operators [operIndex] + " (" + op2 + ")";
					}
				} else {
					if (y != 1) {
						GameManagerJW.Instance.fullProblem += "[" + op1 + " " + operators [operIndex] + " " + op2 + "]";
					} else {
						GameManagerJW.Instance.fullProblem += op1 + " " + operators [operIndex] + " " + op2;
					}
				}

				// here I'm concatenating between paranthesis at random (range index 0, 1, 2, or 3 for + - / *)... we don't want radical or % here :slightly_smiling_face:
				if (j != y - 1 && y != 0) {
					operIndex = Random.Range (0, 4);
					GameManagerJW.Instance.fullProblem += " " + operators [operIndex] + " ";
				}
			}
			if (x != 1)
				GameManagerJW.Instance.fullProblem += "]";
			if (i != x - 1 && x != 0) {
				operIndex = Random.Range (0, 4);
				GameManagerJW.Instance.fullProblem += " " + operators [operIndex] + " ";
			}
		}
		GameManagerJW.Instance.fullProblem += " ";
		//		Debug.Log ("FULL PROB: " + GameManagerJW.Instance.fullProblem);
	}

	// Christian
	private List<string> breakProblem(string problem) {
		List<string> s = new List<string>();
		List<string> t = new List<string>();

		for (int i = 0; i < problem.Length; i++) {
			char c = problem [i];
			if (c == '[' || i == 0)
				s.Add ("");
			for (int j = 0; j < s.Count; j++)
				s [j] += c;
			if (c == ']' || i == problem.Length-1) {
				string text = s [s.Count-1];
				text = text.Replace ("[", "(");
				text = text.Replace ("]", ")");
				s.RemoveAt (s.Count - 1);
				t.Add (text);
			}
		}
		return t;
	}

	// RP
	private void ReadParsedProblem(List<string> p, int i)
	{
		// Reset math text
		mathQuestion.text = "";
		mathQuestion.text += "Full Problem: ";

		// Display entire problem in full above (last index in p)
		if (p != null) {
			mathQuestion.text += p [p.Count - 1];
		} else {
			return;
		}

		// Important: checking for out of range index
		if (i == GameManagerJW.Instance.parsedProblem.Count) { // same as i == p.Count
			GameManagerJW.Instance.isQuestionStarted = false;
			// reloading scene to respawn coins and call Refresh() in Start()
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			// basically calling return;
		} else {
			// Display chunk of index i
			mathQuestion.text += "\n\nEvaluate: " + p [i] + " = ?\n\n";
			PopulateAnswers (p [i]);
			PrintAnswerKey (p [i]);

			//			if (i != 0) {
			//				// so it's chunk1_answer + chunk2... not chunk1+chunk2+...
			// still not working
			//				GameManagerJW.Instance.parsedProblem [i] = answer.ToString ();
			//			}
		}

		//_____For Debugging_____
		foreach (string j in p) {
			Debug.Log (j + "\n");
		}
	}

	// RP
	private void PopulateAnswers (string expression)
	{
		UpdateHint (expression);

		// RP fix
		//		Expression exp = parser.EvaluateExpression(expression);
		//		answer = (float)exp.Value;
		// will not run in build, uses UnityEditor
		//		answer = ExpressionEvaluator.Evaluate<float>(expression);

		// checking for Square root, since ExpressionEvaluator does not handle it
		int isSqrt = expression.IndexOf((char)0x221A);
		int isMod = expression.IndexOf('%');
		if (isSqrt != -1) {
			string temp = expression;
			temp = temp.Remove (isSqrt, 1);
			answer = (float)Mathf.Sqrt (int.Parse (temp));
		} else if (isMod != -1) {
			string[] tempOps = expression.Split('%');
			answer = (float)int.Parse ((tempOps[0])) % int.Parse ((tempOps[1]));
		} else {
			answer = (float) ExpressionParser.Eval(expression);
		}
		//		Debug.Log (answer);

		// for debugging, but now there is a dedicated answer button in hints
		//		mathQuestion.text += "Answer: " + answer;

		// populate answer key with junk, incorrect answer
		int isDiv = expression.IndexOf('/');
		if (isDiv != -1) {
			for (int i = 0; i < SIZE; ++i) {
				answers [i] = Random.Range ((int)answer - 3, (int)answer + 3);

				if (answers [i] == answer) {
					answers [i] = Random.Range ((int)answer - 3, (int)answer + 3);
				}

				for (int j = 0; j < i; ++j) {
					if (answers[i] == answers[j]) {
						answers [i] = Random.Range ((int)answer - 3, (int)answer + 3);

						if (answers [i] == answer) {
							answers [i] = Random.Range ((int)answer - 3, (int)answer + 3);
						}
					}
				}
			}
		} else {
			for (int i = 0; i < SIZE; ++i) {
				// gen rand values within a range of 10 of the answer
				if (answer % 1 == 0) { // cast rand vals to int to match real answer
					answers [i] = Random.Range ((int)answer - 10, (int)answer + 10);
				} else { // leave as float
					answers [i] = Random.Range (answer - 10, answer + 10);
				}
				// we are checking that we don't accidentally / magically
				//		generate the right answer! Will likely never enter this while loop, but it's here to be safe
				// a while() here caused a freeze!
				if (answers [i] == answer) {
					if (answer % 1 == 0) {
						answers [i] = Random.Range ((int)answer - 10, (int)answer + 10);
					} else {
						answers [i] = Random.Range (answer - 10, answer + 10);
					}
				}
			}
		}
		// populate rand arr index with Correct answer
		// 		note: Random.Range(Inclusive val, Exclusive val)
		correctIndex = Random.Range(0, SIZE);
		answers[correctIndex] = answer;
		AnswerCoins [correctIndex].GetComponent<AnswerCoin> ().isCorrect = true;
	}

	// RP
	private void PrintAnswerKey(string expression)
	{
		int isDiv = expression.IndexOf('/');
		if (isDiv != -1)
		{
			mathQuestion.text += " (A) ";
			Fraction newFraction = Fraction.Parse ((double)answers [0]);
			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;

			mathQuestion.text += " (B) ";
			newFraction = Fraction.Parse ((double)answers [1]);
			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;

			mathQuestion.text += " (C) ";
			newFraction = Fraction.Parse ((double)answers [2]);
			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;

			mathQuestion.text += " (D) ";
			newFraction = Fraction.Parse ((double)answers [3]);
			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;
			return;
		}
		mathQuestion.text += " (A) ";
		mathQuestion.text += answers [0];

		mathQuestion.text += " (B) ";
		mathQuestion.text += answers [1];

		mathQuestion.text += " (C) ";
		mathQuestion.text += answers [2];

		mathQuestion.text += " (D) ";
		mathQuestion.text += answers [3];
	}

	/// see <http://stackoverflow.com/questions/95727/how-to-convert-floats-to-human-readable-fractions>
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

	public void DisplayAnswer()
	{
		answerText.text = answer.ToString();
		if (!answerText.gameObject.activeSelf) {
			answerText.gameObject.SetActive (true);
		} else {
			answerText.gameObject.SetActive (false);
		}
	}

	// RP
	private void UpdateHint(string expression)
	{
		string temp = "";


		int isSin = expression.IndexOf('s');
		if (isSin != -1) {
			temp = "Sine, cosine, tangent — a.k.a., sin(θ), cos(θ) and tan(θ) — are functions revealing the shape of a right triangle. Looking out from a vertex with angle θ, \n\n" +
				"sin(θ) is the ratio of the opposite side to the hypotenuse. \n\n" +
				"cos(θ) is the ratio of the adjacent side to the hypotenuse. \n\n" +
				"tan(θ) is the ratio of the opposite side to the adjacent.";
			hintText.text = temp;
			return;
		}

		int isCos = expression.IndexOf('c');
		if (isCos != -1) {
			temp = "Sine, cosine, tangent — a.k.a., sin(θ), cos(θ) and tan(θ) — are functions revealing the shape of a right triangle. Looking out from a vertex with angle θ, \n\n" +
				"sin(θ) is the ratio of the opposite side to the hypotenuse. \n\n" +
				"cos(θ) is the ratio of the adjacent side to the hypotenuse. \n\n" +
				"tan(θ) is the ratio of the opposite side to the adjacent.";
			hintText.text = temp;
			return;
		}

		int isTan = expression.IndexOf('t');
		if (isTan != -1) {
			temp = "Sine, cosine, tangent — a.k.a., sin(θ), cos(θ) and tan(θ) — are functions revealing the shape of a right triangle. Looking out from a vertex with angle θ, \n\n" +
				"sin(θ) is the ratio of the opposite side to the hypotenuse. \n\n" +
				"cos(θ) is the ratio of the adjacent side to the hypotenuse. \n\n" +
				"tan(θ) is the ratio of the opposite side to the adjacent.";
			hintText.text = temp;
			return;
		}

		int isAdd = expression.IndexOf('+');
		if (isAdd != -1) {
			temp = "Use your addition powers! \n\n Try adding the largest left-most values first. \n 910 + 300... do 900 + 300 first, which equals 1200 then add remaining 10!\n\n" +
				"910 + 300 = 1220\n\n" +
				"Another method uses rounding: \n" +
				"Here is an example: 644 + 238\n\nThese numbers are hard to do in your head, so let's make them more manageable.\n" +
				"644 becomes 650 and 238 becomes 240.\n\nAdd 650 and 240 together... ...890 easy right?\n\n" +
				"Now simply subtract what you rounded off. 650 – 644 = 6 and 240 – 238 = 2\n" +
				"6 + 2 = 8. 890 – 8 = 882\n\nThere's your answer!\n" +
				"644 +238 = 882";
			hintText.text = temp;
			return;
		}

		int isDiv = expression.IndexOf('/');
		if (isDiv != -1) {
			temp = "Division tricks\n\nHere’s a quick way to know when a number can be evenly divided by these certain numbers:\n\n" +
				"10 if the number ends in 0\n9 when the digits are added together and the total is evenly divisible by 9\n8 if the last three digits are evenly divisible by 8 or are 000\n" +
				"6 if it is an even number and when the digits are added together the answer is evenly divisible by 3\n5 if it ends in a 0 or 5\n4 if it ends in 00 or a two digit number that" +
				"is evenly divisible by 4\n3 when the digits are added together and the result is evenly divisible by the number 3\n2 if it ends in 0, 2, 4, 6, or 8";
			hintText.text = temp;
			return;
		}

		int isMult = expression.IndexOf('*');
		if (isMult != -1) {
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
			hintText.text = temp;
			return;
		}

		int isExp = expression.IndexOf('^');
		if (isExp != -1) {
			temp = "As with most problems in basic algebra, solving large exponents requires factoring. If you factor the exponent down until all the factors are prime numbers--a process called 'prime factorization'" +
				"-- you can then apply the power rule of exponents to solve the problem. Additionally, you can break the exponent down by addition rather than multiplication and apply the product rule " +
				"for exponents to solve the problem. A little practice will help you predict which method will be easiest for the problem you are faced with. \n\n" +
				"Power Rule\nFind the prime factors of the exponent.\n\nExample: 6^24\n\n24 = 2 * 12 24 = 2 * 2 * 6 24 = 2 * 2 * 2 * 3\n\nUse the power rule for exponents to set up the problem. " +
				"The power rule states: (x^a)^b = x^(a*b)\n\n6^24 = 6^(2 * 2 * 2 * 3) = ((((6^2)^2)^2)^3)\n\nSolve the problem from the inside out.\n\n" +
				"((((6^2)^2)^2)^3) = (((36^2)^2)^3) = ((1296^2)^3) = (1679616^3) = 4.738e18\n\nProduct Rule\nBreak the exponent down into a sum. Make sure the components are small enough " +
				"to work with as exponents and do not include 1 or 0.\n\nExample: 6^24\n\n24 = 12 + 12 24 = 6 + 6 + 6 + 6 24 = 3 + 3 + 3 + 3 + 3 + 3 + 3 + 3\n\nUse the product rule of " +
				"exponents to set up the problem. The product rule states: x^a * x^b = x(a^b)\n\n6^24 = 6^(3 + 3 + 3 + 3 + 3 + 3 + 3 + 3) 6^24 = 6^3 * 6^3 * 6^3 * 6^3 * 6^3 * 6^3 * 6^3 * 6^3\n\nS" +
				"olve the problem.\n\n6^3 * 6^3 * 6^3 * 6^3 * 6^3 * 6^3 * 6^3 * 6^3 = 216 * 216 * 216 * 216 * 216 * 216 * 216 * 216 = 46656 * 46656 * 46656 * 46656 = 4.738e18\n\nTip\nFor some problems, " +
				"a combination of both techniques may make the problem easier. For example: x^21 = (x^7)^3 (power rule), and x^7 = x^3 * x^2 * x^2 (product rule). Combining the two, " +
				"you get: x^21 = (x^3 * x^2 * x^2)^3";
			hintText.text = temp;
			return;
		}

		int isSqrt = expression.IndexOf((char)0x221A); // Square root
		if (isSqrt != -1) {
			temp = "In mathematics, a square root of a number a is a number y such that y² = a, in other words, a number y whose square (the result of multiplying the number by itself, or y * y) is a. \n\n " +
				"For example, 4 and -4 are square roots of 16 because 4² = (-4)² = 16.Every non-negative real number a has a unique non-negative square root, called the principal square root, which is denoted by √a, where √ is called the radical sign or radix. \n\n" +
				" For example, the principal square root of 9 is 3, denoted √9 = 3, because 32 = 3 ^ 3 = 9 and 3 is non-negative. The term whose root is being considered is known as the radicand. The radicand is the number or expression underneath the radical sign, " +
				"in this example 9.The justification for taking out the square root of any number is this theorem to help simplify √a*b = √a * √b. " +
				"The square root of a number is equal to the number of the square roots of each factor.\n\n" +
				"The imaginary number \"i\" is the square root of negative one. An imaginary number possesses the unique property that when squared, the result is negative. " +
				"Consider: The process of simplifying a radical containing a negative factor is the same as normal radical simplification.";
			hintText.text = temp;
			return;
		}

		int isMod = expression.IndexOf('%');
		if (isMod != -1) {
			temp = "What is the % symbol? It's modulus! Divide first and any remainder is your answer!\n\n" +
				"In computing, the modulo operation finds the remainder after division of one number by another (sometimes called modulus). Given two positive numbers, a (the dividend) and n (the divisor), " +
				"a modulo n (abbreviated as a mod n) is the remainder of the Euclidean division of a by n.\n\n";
			hintText.text = temp;
			return;
		}

		// bug fix: this must go last, b/c otherwise expression might contain '-' to mean a negative number, not minus operation
		int isMinus = expression.IndexOf('-');
		if (isMinus != -1) {
			temp = "If number you're subtracting from is smaller (say 2 - 10), simply make the answer -10 and add back 2... 2 - 10 = -8! FLIP and add!\n\n" +
				"When subtracting from 1,000...\nHere’s a basic rule to subtract a large number from 1,000: Subtract every number except the last from 9 and subtract the final number from 10\n\nFor example:\n1,000 – 556\n\n" +
				"Step 1: Subtract 5 from 9 = 4\n\nStep 2: Subtract 5 from 9 = 4\n\nStep 3: Subtract 6 from 10 = 4\n\nThe answer is 444.";
			hintText.text = temp;
			return;
		}
	}
}


//--------------------------------------------------------------------------------------------------------------------------

// FOR TESTING (Christian)
//	private string fullProblem = "((5 - (3 - 7 * (6 - 3) + 5)) % 4)";
//	private void getMath() {
//		//mathQuestion.text = fullProblem;
//		List<string> t = breakProblem (fullProblem);
//		for (int i = 0; i < t.Count; i++) {
//			string expression = t[i];
//			float result = ExpressionEvaluator.Evaluate<float>(expression);
//			//mathQuestion.text += "\n" + expression + " = " + result;
//		}
//	}

// BLOATED VERSION (broken b/c operIndex 4 now equals ^ and 6 equals %)
//	public void GenFullProblem()
//	{
//		// TODO add chunks diff selector in Settings
//
//		// Reset fullProblem
//		GameManagerJW.Instance.fullProblem = "";
//		// needed for breakProblem() to work
//		GameManagerJW.Instance.fullProblem += " ";
//
//		// bug fix: performing these rand operations inside of if statement froze untiy
//		op1 = Random.Range (GameManagerJW.Instance.getMinRand (), GameManagerJW.Instance.getMaxRand ());
//		op2 = Random.Range (GameManagerJW.Instance.getMinRand (), GameManagerJW.Instance.getMaxRand ());
//		int probOfSqrtOrMod = Random.Range (0, 5);
//		operIndex = Random.Range (0, OPER_SIZE);
//		if ( (operIndex == 4 || operIndex == 5) && probOfSqrtOrMod == 1) {
//			// Square roots
//			if (operIndex == 5) {
//				GameManagerJW.Instance.fullProblem += operators [operIndex] + " " + Mathf.Abs (op2);
//			}
//			// Modulus
//			else {
//				GameManagerJW.Instance.fullProblem += Mathf.Abs (op1) + " " + operators [operIndex] + " " + Mathf.Abs (op2);
//			}
//			GameManagerJW.Instance.fullProblem += " ";
//			Debug.Log (GameManagerJW.Instance.fullProblem);
//			return;
//		}
//
//		// bug fix: setting min val to 1 otherwise sometimes turns up empty string
//		int howManyChunks = Random.Range(1, 3);
//		bool isOpenParan = false;
//
//		for (int i = 0; i < howManyChunks; i++)
//		{
//			int addParan = Random.Range (0, 11);
//			if (addParan > 2 && isOpenParan == false && howManyChunks > 1) {
//				GameManagerJW.Instance.fullProblem += "( ";
//				isOpenParan = true;
//			}
//
//			int moreChunks = Random.Range (1, 4);
//			for (int j = 0; j < moreChunks; j++)
//			{
//				addParan = Random.Range (0, 11);
//				if (addParan < 2 && isOpenParan == false && moreChunks > 1) {
//					GameManagerJW.Instance.fullProblem += "( ";
//					isOpenParan = true;
//				}
//				// generate random values for operands
//				op1 = Random.Range (GameManagerJW.Instance.getMinRand (), GameManagerJW.Instance.getMaxRand ());
//				op2 = Random.Range (GameManagerJW.Instance.getMinRand (), GameManagerJW.Instance.getMaxRand ());
//
//				// range index 0, 1, 2, or 3 for + - / * NO % or radicals... too hard
//				operIndex = Random.Range (0, 4);
//				GameManagerJW.Instance.fullProblem += op1 + " " + operators [operIndex] + " " + op2 + " ";
//
//				int innerCloseParan = Random.Range (0, 11);
//				if ((j == moreChunks - 1 || moreChunks == 0) && isOpenParan == true) {
//					GameManagerJW.Instance.fullProblem += ")";
//					isOpenParan = false;
//				} else if (innerCloseParan < 2 && isOpenParan == true) {
//					GameManagerJW.Instance.fullProblem += ")";
//					isOpenParan = false;
//				}
//
//				// here I'm concatenating between paranthesis at random (range index 0, 1, 2, or 3 for + - / *)... we don't want radical or % here :)
//				// 		or if there's just two numbers next to each other
//				int concat = Random.Range (0, 11);
//				if ( (concat < 3 && j != moreChunks - 1 && moreChunks != 0) || (isOpenParan == false && j != moreChunks - 1) ) {
//					operIndex = Random.Range (0, 4);
//					GameManagerJW.Instance.fullProblem += " " + operators [operIndex] + " ";
//				}
//			}
//
//			int closeParan = Random.Range (0, 11);
//			if ((i == howManyChunks - 1 || howManyChunks == 0) && isOpenParan == true) {
//				GameManagerJW.Instance.fullProblem += ")";
//				isOpenParan = false;
//			} else if (closeParan > 2 && isOpenParan == true) {
//				GameManagerJW.Instance.fullProblem += ")";
//				isOpenParan = false;
//			}
//		}
//		GameManagerJW.Instance.fullProblem += " ";
//		Debug.Log (GameManagerJW.Instance.fullProblem);
//	}

// LEGACY FUNCTION; not in use
//	public void GenerateMath()
//	{
//		// generate random values for operands
//		op1 = Random.Range(GameManagerJW.Instance.getMinRand(), GameManagerJW.Instance.getMaxRand());
//		op2 = Random.Range(GameManagerJW.Instance.getMinRand(), GameManagerJW.Instance.getMaxRand());
//
//		float answer = PerformOp (op1, op2);
//
//		// populate answer key with junk, incorrect answer
//		for (int i=0; i<SIZE; ++i)
//		{
//			// gen rand values within a range of 10 of the answer
//			if (answer % 1 == 0) { // cast rand vals to int to match real answer
//				answers [i] = Random.Range ((int)answer - 10, (int)answer + 10);
//			} else { // leave as float
//				answers [i] = Random.Range (answer - 10, answer + 10);
//			}
//			// we are checking that we don't accidentally / magically
//			//		generate the right answer! Will likely never enter this while loop, but it's here to be safe
//			while (answers[i] == answer) {
//				if (answer % 1 == 0) {
//					answers [i] = Random.Range ((int)answer - 10, (int)answer + 10);
//				} else {
//					answers [i] = Random.Range (answer - 10, answer + 10);
//				}
//			}
//		}
//		// populate rand arr index with Correct answer
//		// 		note: Random.Range(Inclusive val, Exclusive val)
//		correctIndex = Random.Range(0, SIZE);
//		answers[correctIndex] = answer;
//		AnswerCoins [correctIndex].GetComponent<AnswerCoin> ().isCorrect = true;
//	}

// LEGACY not in use
//	private float PerformOp(float a, float b) {
//		float temp = 0;
//		switch (operIndex)
//		{
//			case 0:
//				temp = a + b;
//				break;
//			case 1:
//				temp = a - b;
//				break;
//			case 2:
//				temp = a / b;
//				break;
//			case 3:
//				temp = a * b;
//				break;
//			case 4:
//				// EXPONENTS ^
//				break;
//			case 6:
//				// performing modulus (and square root) on negative numbers is wonky, so using abs val
//				temp = Mathf.Abs(a) % Mathf.Abs(b);
//				break;
//			case 5:
//				// for square roots, only op b (op2) will be processed
//				temp = Mathf.Sqrt (Mathf.Abs(b));
//				break;
//		}
//		return temp;
//	}

// LEGACY not in use
//	private void PrintMath() {
//		// RP 2017-12-1
//		// if square root, then diplay only op2
//		if (operIndex == 5) {
//			mathQuestion.text = "Evaluate: " + operators [operIndex] + Mathf.Abs (op2) + " = ? \n\n" +
//			"(A) ";
//		} else if (operIndex == 4) {
//			mathQuestion.text = "Evaluate: " + Mathf.Abs(op1) + " " + operators [operIndex] + " " + Mathf.Abs(op2) + " = ? \n\n" +
//					"(A) ";
//		} else {
//			mathQuestion.text = "Evaluate: " + op1 + " " + operators [operIndex] + " " + op2 + " = ? \n\n" +
//			"(A) ";
//		}
//
//		if (operIndex == 2) { // if performing division, convert to fraction
//			Fraction newFraction = Fraction.Parse ((double)answers [0]);
//			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;
//		} else {
//			mathQuestion.text += answers [0];
//		}
//
//		mathQuestion.text += " (B) ";
//		if (operIndex == 2) { // if performing division, convert to fraction
//			Fraction newFraction = Fraction.Parse ((double)answers [1]);
//			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;
//		} else {
//			mathQuestion.text += answers [1];
//		}
//
//		mathQuestion.text += " (C) ";
//		if (operIndex == 2) { // if performing division, convert to fraction
//			Fraction newFraction = Fraction.Parse ((double)answers [2]);
//			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;
//		} else {
//			mathQuestion.text += answers [2];
//		}
//
//		mathQuestion.text += " (D) ";
//		if (operIndex == 2) { // if performing division, convert to fraction
//			Fraction newFraction = Fraction.Parse ((double)answers [3]);
//			mathQuestion.text += newFraction.Numerator + "/" + newFraction.Denominator;
//		} else {
//			mathQuestion.text += answers [3];
//		}
//	}

// END SCRIPT