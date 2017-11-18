using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tutorialManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// (RP)
	public void ChooseTutorial() {
		int chosenInt = GameObject.Find ("TutorialDropdownUpper").GetComponent<Dropdown>().value;
		string dest = "tut_" + chosenInt;
		SceneManager.LoadScene(dest);
	}
}
