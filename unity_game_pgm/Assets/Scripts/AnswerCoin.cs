using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Modified Data: 2017/11/13
BY: Jun
*/

public class AnswerCoin : MonoBehaviour {

	public AudioSource coinAudio;	//audio object 
	public GameObject GameController;  //GameController object 
	public bool isCorrect = false;

	// Use this for initialization
	void Start () {

		// b/c of Jun's code below, we can just leave public variables blank

		if (GameController == null) {
			//To get GameController object through FindWithTag method.
			GameController = GameObject.FindWithTag ("GameController"); 
		}

		if (coinAudio == null) {
			coinAudio = GetComponent<AudioSource> ();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	//Sent when an incoming collider makes contact with this object's collider
	void OnTriggerEnter2D()
	{
		if (isCorrect) {
			GameController.GetComponent<Score> ().DoubleScore();
			// RP 2017-11-27
			// if correct answer, boost up time by 15 sec
			GameManagerJW.Instance.increaseTime (15f);
		} else {
			GameController.GetComponent<Score> ().LoseScore();
			GameManagerJW.Instance.increaseTime (-15f);
		}
		coinAudio.Play (); // play the audio 

		GetComponent<SpriteRenderer> ().enabled = false; //make the sprite unvisible.
		GetComponent<BoxCollider2D> ().enabled = false;
		Destroy (this.gameObject,1);// Kills the game object in 1 seconds after loading the object
	}
}