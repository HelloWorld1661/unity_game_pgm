using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Coin : MonoBehaviour {
	public AudioSource coinAudio;	//audio object 
//	public GameObject controller;  //GameController object 

	// Use this for initialization
	void Start () {
//		if (controller == null) {
//			//To get GameController object through FindWithTag method.
//			controller = GameObject.FindWithTag ("GameController"); 
//		}

		if (coinAudio == null) {
			coinAudio = GetComponent<AudioSource> ();
		}
	}

	// Update is called once per frame
	void Update () { }

	//Sent when an incoming collider makes contact with this object's collider
	void OnTriggerEnter2D()
	{
		var text = gameObject.GetComponentInChildren<Text> ();
		// returns Right Answer if player collects right answer coin
		if (text && text.tag == "Answer")
			Debug.Log ("Right Answer!");
		
		Debug.Log ("Collided!");

		coinAudio.Play (); // play the audio 

		GetComponent<SpriteRenderer> ().enabled = false; //make the sprite unvisible.
		GetComponent<BoxCollider2D> ().enabled = false;
		Destroy (this.gameObject,1);// Kills the game object in 1 seconds after loading the object
	}
}
