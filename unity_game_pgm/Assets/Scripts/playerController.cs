using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playerController : MonoBehaviour {
	public Rigidbody2D rigid; 
	private float movement; 
	public float speed =7.0f; 
	public bool isFaceRight = true; 
	public Transform groundCheck; 
	private float groundRadius = 0.5f;
	public LayerMask whatIsGround;
	public bool grounded = false; 
	Animator anim;

	// old Jump methods not in use - updated with better solution (see JumpBetter.cs script)
//	private bool jumpPressed = false;
//	private float jumpDuration = 0f;
	[Range(1,10)]
	public float jumpVelocity;

	void Start () {
		if (rigid == null) {
			rigid = GetComponent<Rigidbody2D> (); 
		}
		anim = GetComponent<Animator> ();
	}
		
	void Update () {
		movement = Input.GetAxis ("Horizontal");

		if (Input.GetButtonDown ("Jump") && isGrounded()) {
			rigid.velocity = Vector2.up * jumpVelocity;
		}


//		// original jump code
//		if(Input.GetButtonDown("Jump")){
//			jumpPressed = true;
//		}

		// RP 10/19/17 see <http://answers.unity3d.com/questions/300452/how-to-do-a-jump-relative-to-the-time-the-key-spen.html>
//		if (Input.GetButtonDown ("Jump") && isGrounded()){
//			jumpDuration = 0.18f; 				// start the timer when the key goes down
//		}
//		if (jumpDuration > 0){ 					// if timer is running...
//			if (Input.GetButtonUp ("Jump")){ 	// and key goes up...
//				jumpDuration = 0; 				// deactivate the timer...
//				jumpPressed = true;
//			} else { 							// but if key still pressed...
//				jumpDuration -= Time.deltaTime; // decrement the timer
//				if (jumpDuration <= 0){ 		// if time elapsed...
//					jumpForce *= 1.28f;			// jump anyway with increased jumpForce:
//					jumpPressed = true;
//				}
//			}
//		}
	}
		
	void FixedUpdate() {
		rigid.velocity = new Vector2 (speed * movement, rigid.velocity.y); // needed to move left/right
		grounded = isGrounded ();  

		anim.SetBool ("Ground", grounded); 
		if((movement<0 && isFaceRight)||(movement>0 && !isFaceRight)){
			flip ();
		}
//		if (jumpPressed && isGrounded ()) {
//			Jump ();
//		}
		anim.SetFloat ("Speed", Mathf.Abs (movement));
		anim.SetFloat("vSpeed", rigid.velocity.y);

		if (gameObject.transform.position.y < -12.0) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

//	void Jump(){
//		rigid.velocity = new Vector2 (rigid.velocity.x, 0);
//		rigid.AddForce (new Vector2 (0, jumpForce));
//		jumpPressed = false; 	// reset jumpForce for correct updates
//		jumpForce = 500.0f;
//	}

	bool isGrounded(){
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		return grounded;
	}

	void flip(){
		Vector3 playerScale = transform.localScale;
		playerScale.x = playerScale.x * -1;
		transform.localScale = playerScale;
		isFaceRight = !isFaceRight;
	}
}