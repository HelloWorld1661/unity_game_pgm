using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseResume : MonoBehaviour {

	public GameObject[] displayWhenPlay;
	public GameObject[] displayWhenPaused;

	// Use this for initialization
	void Start () {

		displayWhenPlay = GameObject.FindGameObjectsWithTag ("showInPlayMode");
		displayWhenPaused = GameObject.FindGameObjectsWithTag ("showInPauseMode");

		// deactivate game objects that should only be displayed when game is paused -Prof
		foreach (GameObject g in displayWhenPaused) {
			// calling parent obj as workaround solution for using mult tags
			// 		see <https://answers.unity.com/questions/21664/is-it-possible-to-have-multiple-tags-or-the-like-o.html>
			g.transform.parent.gameObject.SetActive (false);
			g.SetActive (false);
		}

		// active game objects that should be displayed when game is in play mode -Prof
		foreach (GameObject g in displayWhenPlay) {
			g.transform.parent.gameObject.SetActive (true);
			g.SetActive (true);
		}
	}

	// Update is called once per frame
	void Update () {

	}

	public void Pause()
	{
		// activate paused items, deactivate play items -Prof
		// stop time
		Time.timeScale = 0.0f;

		foreach (GameObject g in displayWhenPaused) {
			// TODO apply all tags as children to fix bug and omit <g.SetActive()>
//			g.transform.parent.gameObject.SetActive (true);
			g.SetActive (true);
		}

		foreach (GameObject g in displayWhenPlay) {
//			g.transform.parent.gameObject.SetActive (false);
			g.SetActive (false);
		}
	}

	public void Resume()
	{
		// activate play items, deactivate pause items -Prof
		// resume time
		Time.timeScale = 1.0f;

		foreach (GameObject g in displayWhenPaused) {
//			g.transform.parent.gameObject.SetActive (false);
			g.SetActive (false);
		}

		// active game objects that should be displayed when game is in play mode -Prof
		foreach (GameObject g in displayWhenPlay) {
//			g.transform.parent.gameObject.SetActive (true);
			g.SetActive (true);
		}
	}

	public void GoToMenu()
	{
		SceneManager.LoadScene ("lab_7Menu");
	}
}