using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.Events;

public class Difficulty : MonoBehaviour {

	public InputField minInput;
	public InputField maxInput;
	public Text DiffTitle;


	void Awake ()
	{
		if (GameManagerJW.Instance.getMinRand () != -20) {
			minInput.text = GameManagerJW.Instance.getMinRand ().ToString ();
		}
		if (GameManagerJW.Instance.getMaxRand () != 21) {
			// minusing 1 to compensate for Random func's exclusive property on max val
			maxInput.text = (GameManagerJW.Instance.getMaxRand () -1 ).ToString ();
		}
	}

	void Update ()
	{
		SetColor ();
	}

	public void SetMinValue() {
		GameManagerJW.Instance.setMinRand (int.Parse(minInput.text));
	}

	public void SetMaxValue() {
		GameManagerJW.Instance.setMaxRand (int.Parse(maxInput.text));
	}

	public void SetDefault() {
		GameManagerJW.Instance.setRandDefault ();
		minInput.text = "Enter Min Value";
		maxInput.text = "Enter Max Value";
	}

	public void SetColor() {
		if (GameManagerJW.Instance.getMinRand () <= -1000 || GameManagerJW.Instance.getMaxRand () > 1001) {
			DiffTitle.color = Color.black;
			DiffTitle.text = "NINJA MODE";
		} else if (GameManagerJW.Instance.getMinRand () <= -200 || GameManagerJW.Instance.getMaxRand () > 201) {
			DiffTitle.color = Color.red;
			DiffTitle.text = "Difficulty";
		} else if (GameManagerJW.Instance.getMinRand () <= -100 || GameManagerJW.Instance.getMaxRand () > 101) {
			DiffTitle.color = Color.magenta;
			DiffTitle.text = "Difficulty";
		} else if (GameManagerJW.Instance.getMinRand () <= -50 || GameManagerJW.Instance.getMaxRand () > 51) {
			DiffTitle.color = Color.yellow;
			DiffTitle.text = "Difficulty";
		} else if (GameManagerJW.Instance.getMinRand () >= -20 && GameManagerJW.Instance.getMaxRand () <= 21) {
			DiffTitle.color = Color.green;
			DiffTitle.text = "Difficulty";
		} else {
			DiffTitle.color = Color.blue;
			DiffTitle.text = "Difficulty";
		}
	}
}
