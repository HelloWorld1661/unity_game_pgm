using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ImageGallery : MonoBehaviour {


	// apply this script on a sprite object (RP)
	public Sprite[] gallery; 
	private int i = 0;

	void Awake() {
		// init
		this.GetComponent<SpriteRenderer>().sprite = gallery[0];
	}

	public void BtnNext(){
		if (i + 1 < gallery.Length) { i++; }
		this.GetComponent<SpriteRenderer>().sprite = gallery[i];
	}

	public void BtnPrev() {
		if (i > 0) { i--; }
		this.GetComponent<SpriteRenderer>().sprite = gallery[i];
	}

	void Update() {
		// TODO fix this, for some reason not capturing input...

		// capture input for keydown L and R
//		if (Input.GetKeyDown("right") && (i + 1 < gallery.Length)) {
//			i++;
//			this.GetComponent<SpriteRenderer>().sprite = gallery[i];
//		} else if (Input.GetKeyDown("left") && (i > 0)) {
//			i--;
//			this.GetComponent<SpriteRenderer>().sprite = gallery[i];
//		}

//		if (Input.GetKeyDown ("right")) {
//			Debug.Log ("rightKeyPressed");
//		}
	}
}