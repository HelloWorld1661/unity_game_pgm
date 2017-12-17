using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SimpleFormula : MonoBehaviour {


	//This is the parent of the text objects that we are going to create
	public Canvas target_Canvas;
	//This is the prefab used for simple text
	public GameObject prefabText;
	//This is the prefab used to create fractions of type ()/()
	public GameObject prefabFraction;
	//This is the prefab used to create power of type ()^()
	public GameObject prefabPower;
	//This is the prefab used to create limits of type ()L()
	public GameObject prefabLimit;
	// this is the equation in a text format
	public string equation;
	//this is the the public variable that is going to set the distances between equations:
	public int letterDistance;
	//offset to place X and Y text in percentage
	public float offsetX, offsetY;
	// size of the fonts:
	public int fSize;

	//these are local variables to refer to the instances of the formula types:
	GameObject fraction, text, power, limit;

	void Start () 
	{

	}


	//this function creates the equation by adding/combining different prefabs and changing the texts inside
	public void CreateEquation()
	{


		// change all font texts

		/* reference to the text object
		GameObject TextObj = Instantiate (prefabText, new Vector3 (0, 0, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
		TextObj.transform.SetParent( target_Canvas.transform);

		Text equationText = TextObj.GetComponent<Text>();
		*/

		// algorithm to detect the type of equation that it is needed to instanciate.


		int jj = 0;
		string a = "";
		string b = "";
		string c = "";

		int eqnPos = 0;

		while ( jj< equation.Length)
		{
			

			// beginning of the ( a )
			if ("" + equation [jj] == "(") {


				eqnPos+= Mathf.Max(c.Length,3)*letterDistance;

				text = Instantiate (prefabText, new Vector3 (0, 0, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
				text.transform.SetParent( target_Canvas.transform);
				text.GetComponent<RectTransform> ().position = new Vector3 (offsetX*Camera.main.pixelWidth+eqnPos- (Mathf.Max(c.Length,3)*letterDistance)/2, offsetY*Camera.main.pixelHeight, 0);
				text.GetComponent<Text> ().text = c;
				text.GetComponent<Text> ().fontSize = fSize;

				//clear c
				c="";

				jj += 1;
				while ("" + equation [jj] != ")" && jj < 1000) {
					a += equation [jj];
					jj += 1;	

				}

			} 


			// detecting the last part of the fraction
			if ("" + equation [jj] == "/") {
				
				jj += 1;

				// detecting next part of the fraction ( b )
				if ("" + equation [jj] == "(") {
					jj += 1;
					while ("" + equation [jj] != ")" && jj < 1000) {
						b += equation [jj];
						jj += 1;	
					}

					// type=fraction we get its position according to the max size of the arrays of the a or b parts of the fracction.
					eqnPos += Mathf.Max (a.Length, b.Length) * letterDistance;
					fraction = Instantiate (prefabFraction, new Vector3 (0, 0, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
					fraction.transform.SetParent (target_Canvas.transform);
					fraction.GetComponent<RectTransform> ().position = new Vector3 (offsetX*Camera.main.pixelWidth+eqnPos-(Mathf.Max (a.Length, b.Length) * letterDistance)/2, offsetY*Camera.main.pixelHeight, 0);



					//set each part of the equation to its text value and correct size
					//  0== a   1==b   2== fraction line mark
					fraction.transform.GetChild (0).GetComponent<Text> ().text = a;
					fraction.transform.GetChild (0).GetComponent<Text> ().fontSize = fSize;
					fraction.transform.GetChild (1).GetComponent<Text> ().text = b;
					fraction.transform.GetChild (1).GetComponent<Text> ().fontSize = fSize;
					fraction.transform.GetChild (2).GetComponent<RectTransform> ().sizeDelta = new Vector2 (  Mathf.Max (a.Length, b.Length) * letterDistance, 1);

					//clear a and b for next mathematical expressions
					a = "";
					b = "";
				}
			} 
			//power!
			if ("" + equation [jj] == "^") {
				
				jj += 1;

				// detecting next part of the power ^( b )
				if ("" + equation [jj] == "(") {
					jj += 1;
					while ("" + equation [jj] != ")" && jj < 1000) {
						b += equation [jj];
						jj += 1;	
					}


					// we get its position according to the sum of the arrays of the a or b parts of the power +2  --> ( +).
					eqnPos += (int)(a.Length+b.Length) * letterDistance;
					power = Instantiate (prefabPower, new Vector3 (0, 0, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
					power.transform.SetParent (target_Canvas.transform);
					power.GetComponent<RectTransform> ().position = new Vector3 (offsetX*Camera.main.pixelWidth+eqnPos-( (a.Length+ 2*b.Length) * letterDistance)/2, offsetY*Camera.main.pixelHeight, 0);


					//set each part of the equation to its text value and correct size
					//  0== a   1==b   2== fraction line mark

					if (a.Length > 1) {
						power.transform.GetChild (0).GetComponent<Text> ().text = "(" + a + ")";
						power.transform.GetChild (0).GetComponent<Text> ().fontSize = fSize;
					} else {
						power.transform.GetChild (0).GetComponent<Text> ().text = a;
						power.transform.GetChild (0).GetComponent<Text> ().fontSize = fSize;
					}
					power.transform.GetChild (1).GetComponent<Text> ().text = b;
					power.transform.GetChild (1).GetComponent<Text> ().fontSize = (int) (fSize*0.6f);
					power.transform.GetChild (1).GetComponent<RectTransform> ().position+=new Vector3 ((a.Length+b.Length)* letterDistance/2, 0, 0);


					//clear a and b for next mathematical expressions
					a = "";
					b = "";
				}
			} 
			//limits!
			if ("" + equation [jj] == "L") {

				jj += 1;

				// detecting next part of the limit (x--> b )
				if ("" + equation [jj] == "(") {
					jj += 1;
					while ("" + equation [jj] != ")" && jj < 1000) {
						b += equation [jj];
						jj += 1;	
					}


					// 
					eqnPos += (int)(a.Length+5) * letterDistance;
					limit= Instantiate (prefabLimit, new Vector3 (0, 0, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
					limit.transform.SetParent (target_Canvas.transform);
					limit.GetComponent<RectTransform> ().position = new Vector3 (offsetX*Camera.main.pixelWidth+eqnPos-( (a.Length) * letterDistance)/2, offsetY*Camera.main.pixelHeight, 0);


					//set each part of the equation to its text value and correct size
					//  0== a   1==b   2== fraction line mark


					limit.transform.GetChild (0).GetComponent<Text> ().text = a;
					limit.transform.GetChild (0).GetComponent<Text> ().fontSize = fSize;
					limit.transform.GetChild (1).GetComponent<RectTransform> ().position=new Vector3 (offsetX*Camera.main.pixelWidth+eqnPos-( (a.Length+3) * letterDistance), offsetY*Camera.main.pixelHeight, 0);
					limit.transform.GetChild (1).GetChild (1).GetComponent<Text> ().text = b;
					limit.transform.GetChild (1).GetChild (1).GetComponent<Text> ().fontSize = fSize;


					//clear a and b for next mathematical expressions
					a = "";
					b = "";
				}
			} 

			// simple solo text in the equation
			if(""+ equation [jj] != "(" && ""+ equation [jj] != ")"  && ""+ equation [jj] != "/"&& ""+ equation [jj] != "^")
			{
				c += equation [jj];
			}



			// last part of the equation in simple text
			if ( (jj == equation.Length - 1) && c.Length > 0) 
			{
				eqnPos+= Mathf.Max(c.Length,3)*letterDistance;

				text = Instantiate (prefabText, new Vector3 (0, 0, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
				text.transform.SetParent( target_Canvas.transform);
				text.GetComponent<RectTransform> ().position = new Vector3 (offsetX*Camera.main.pixelWidth+eqnPos- (Mathf.Max(c.Length,3)*letterDistance)/2, offsetY*Camera.main.pixelHeight, 0);
				text.GetComponent<Text> ().text = c;
				text.GetComponent<Text> ().fontSize = fSize;
			}

			jj+=1;
		}



	}


}
