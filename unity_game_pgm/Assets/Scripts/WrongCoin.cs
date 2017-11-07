﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 Data: 2017/10/29
 Author: Jun
*/

public class WrongCoin : MonoBehaviour {
	public AudioSource coinAudio;	//audio object 
	public GameObject GameController;  //GameController object 

	// Use this for initialization
	void Start () {
		if (GameController == null) {
			//To get GameController object through FindWithTag method.
			GameController = GameObject.FindWithTag ("GameController"); 
		}

		if (coinAudio == null) {
			coinAudio = GetComponent<AudioSource> ();
		}
	}

	// Update is called once per frame
	void Update () { }

	//Sent when an incoming collider makes contact with this object's collider
	void OnTriggerEnter2D()
	{
		GameController.GetComponent<Score>().LoseScore();
		coinAudio.Play (); // play the audio 

		GetComponent<SpriteRenderer> ().enabled = false; //make the sprite unvisible.
		GetComponent<BoxCollider2D> ().enabled = false;
		Destroy (this.gameObject,1);// Kills the game object in 1 seconds after loading the object
	}
}