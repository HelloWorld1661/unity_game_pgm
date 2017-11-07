using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ImageGallery : MonoBehaviour {


	// apply this script on a sprite object (RP)
	public Sprite[] gallery; 
	public Button nextImg;
	public Button prevImg;
	public int i = 0;

	void Awake () {
		// init
		this.GetComponent<SpriteRenderer>().sprite = gallery[0];
	}

	public void BtnNext (){
		if(i + 1 < gallery.Length){
			i++;
		}
	}

	public void BtnPrev () {
		if (i - 1 > 0){
			i --;
		}
	}
	void Update () {
		this.GetComponent<SpriteRenderer>().sprite = gallery[i];
	}
}