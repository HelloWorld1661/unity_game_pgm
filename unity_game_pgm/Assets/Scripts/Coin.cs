using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	public AudioSource audio;	//audio object 
//	public GameObject controller;  //GameController object 

	// Use this for initialization
	void Start () {
//		if (controller == null) {
//			//To get GameController object through FindWithTag method.
//			controller = GameObject.FindWithTag ("GameController"); 
//		}

		if (audio == null) {
			audio = GetComponent<AudioSource> ();
		}
	}

	// Update is called once per frame
	void Update () { }

	//Sent when an incoming collider makes contact with this object's collider
	void OnTriggerEnter2D()
	{
		Debug.Log ("Collided!");

		audio.Play (); // play the audio 

		GetComponent<SpriteRenderer> ().enabled = false; //make the sprite unvisible.
		GetComponent<BoxCollider2D> ().enabled = false;
		Destroy (this.gameObject,1);// Kills the game object in 1 seconds after loading the object
	}
}
