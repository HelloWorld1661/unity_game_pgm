using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// RP 2017-11-27


public class ShowHideHint : MonoBehaviour {

	private GameObject[] displayHint;


	void Awake ()
	{
		displayHint = GameObject.FindGameObjectsWithTag ("Hint");
		CloseHint ();
	}

	public void OpenHint() {
		foreach (GameObject g in displayHint) {
			// RP do NOT use the parent, it is only for future reference
//			g.transform.parent.gameObject.SetActive (true);
			g.SetActive (true);
			Time.timeScale = 0.0f;
//			Debug.Log ("OPEN HINT CLICKED");
		}
	}

	public void CloseHint() {
		foreach (GameObject g in displayHint) {
			g.SetActive (false);
			Time.timeScale = 1.0f;
		}
	}
}