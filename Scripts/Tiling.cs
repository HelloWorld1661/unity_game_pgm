using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// require / call for component - if not there, unity will create it
[RequireComponent (typeof(SpriteRenderer))]

public class Tiling : MonoBehaviour {

	public int offsetX = 2;

	// checking if we need to instantiate things
	public bool hasRightBuddy = false;
	public bool hasLeftBuddy = false;

	// used if obj not tileable
	public bool revScale = false;

	// el width
	private float spriteWidth = 0f;
	private Camera cam;
	private Transform myTransform;

	void Awake() {
		cam = Camera.main;
		myTransform = transform;
	}

	// Use this for initialization
	void Start () {
		SpriteRenderer sRenderer = GetComponent<SpriteRenderer> ();
		spriteWidth = sRenderer.sprite.bounds.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (hasLeftBuddy == false || hasRightBuddy == false) {
			// calc the cam's extend (half width) of what cam can see in world coordinates
			float camHorizontalExtend = cam.orthographicSize * Screen.width / Screen.height;
			// calc the x pos where cam can see the edge of sprite el
			float edgeVisiblePosRight = (myTransform.position.x + spriteWidth/2) - camHorizontalExtend;
			// flip arith
			float edgeVisiblePosLeft = (myTransform.position.x -  spriteWidth/2) + camHorizontalExtend;

			// checking if we can see edge of el
			// then calling MakeNewBuddy func if needed
			if (cam.transform.position.x >= edgeVisiblePosRight - offsetX && hasRightBuddy == false) {
				MakeNewBuddy (1); // 1 b/c we want it on the right
				hasRightBuddy = true;
			} else if (cam.transform.position.x <= edgeVisiblePosLeft + offsetX && hasLeftBuddy == false) {
				MakeNewBuddy (-1);
				hasLeftBuddy = true;
			}
		}
	}

	// makes new buddy on required side
	void MakeNewBuddy(int rightOrLeft) {
		// calc new pos for new buddy
		Vector3 newPos = new Vector3(myTransform.position.x + spriteWidth * rightOrLeft, myTransform.position.y, myTransform.position.z);
		// myTransform is clone of obj
		// instantitaing and storing new buddy in Transform obj
		Transform newBuddy = (Transform)Instantiate(myTransform, newPos, myTransform.rotation); // or we can typecast with <as Transform;>

		// if not tileable rev x to smooth over seams
		if (revScale == true) {
			newBuddy.localScale = new Vector3 (newBuddy.localScale.x * -1, newBuddy.localScale.y, newBuddy.localScale.z);
		}

		newBuddy.parent = myTransform.parent;
		if (rightOrLeft > 0) {
			newBuddy.GetComponent<Tiling> ().hasLeftBuddy = true;
		} else {
			newBuddy.GetComponent<Tiling> ().hasRightBuddy = true;
		}
	}
}
