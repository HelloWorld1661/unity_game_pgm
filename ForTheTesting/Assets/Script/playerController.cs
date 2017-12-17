using System.Collections;    //The System.Collections namespace contains 
//interfaces and classes that define various 
//collections of objects, such as lists, queues, 
//bit arrays, hash tables, and dictionaries.

using UnityEngine;    // The UnityEngine namespace contains interfaces and 
// class definitions that let MonoDevelop know about 
// all the addressable objects inside Unity.

public class playerController : MonoBehaviour {    //The : symbol signifies that playerController inherit from MonoBehaviour.

	//Adding a Rigidbody2D component to a sprite puts in under the control of 
	//the physics engine. By itself, this means that the sprite will be affected 
	//by gravity and can be controlled from scripts using forces.
	public Rigidbody2D rigid;

	public float moveHorizontal;    // moveHorizotal mapped to joystick keys A, D, arrow keys LEFT and RIGHT.
	public float moveVertical;    // moveVertical    mapped to joystick keys W, S, arrow keys UP and DOWN.

	public float playerSpeed = 5.0f; // Movement modifier applied to directional movement.

	public bool isFacingRight = true;    

	public Transform bulletGoRight; // bullet go to right side.
	public Transform bulletGoLeft; // bullet go to Left side.

	Animator anim;

	// Start is only called once in the lifetime of the behavior when the game starts
	// Use this for initialization
	void Start () {
		if (rigid == null) {
			rigid = GetComponent<Rigidbody2D> ();    //get Rigidbody 2D component and refer to reference rigid.
		}
		if (anim == null) {
			anim = GetComponent<Animator> ();
		}
	}

	// Update is called once per frame
	//Called irregularly -- best used for user input
	void Update () {
		getUserInput(); //To get user input
	}

	//called at a fixed rate. Best for physics (e.g. movement)
	void FixedUpdate(){
		movement();    // Move the player's body
		moveSpeed ();
	}

	//Sent when an incoming collider makes contact with this object's collider
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "cat") {
			anim.SetBool ("catchMyHeart", true);
		}
	}

	void moveSpeed(){
		if (Mathf.Abs (moveHorizontal) > 0) {
			anim.SetFloat ("speed", Mathf.Abs (moveHorizontal));
		} else if (Mathf.Abs (moveVertical) > 0) {
			anim.SetFloat ("speed", Mathf.Abs (moveVertical));
		} else {
			anim.SetFloat ("speed", 0.0f);
		}
	}



	void movement(){ // Will move the player based off of keys pressed
		rigid.velocity = new Vector2(moveHorizontal*playerSpeed, moveVertical*playerSpeed);

		//The condition to flip player object that is user input and the orientation of player object are opposite.
		if ((moveHorizontal < 0 && isFacingRight) || (moveHorizontal > 0 && !isFacingRight)) {
			flip ();
		}
	}

	void getUserInput(){
		moveHorizontal = Input.GetAxis ("Horizontal");    //get horizontal movement
		moveVertical = Input.GetAxis ("Vertical");    //get vertical movement

	}

	void flip(){
		Vector2 playerScale = transform.localScale;
		playerScale.x = playerScale.x * -1;
		transform.localScale = playerScale;
		isFacingRight = !isFacingRight;
	}

}