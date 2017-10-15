using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	public Rigidbody2D rigid; 
	public float movement; 
	public float speed =7.0f; 
	public bool isFaceRight = true; 

	public Transform groundCheck; 
	private float groundRadius = 0.5f;

	public LayerMask whatIsGround;
	public bool grounded = false; 

	public bool jumpPressed = false;
	public float jumpForce = 100.0f;
	Animator anim;

	void Start () {
		if (rigid == null) {
			rigid = GetComponent<Rigidbody2D> (); 
		}
		anim = GetComponent<Animator> ();
	}
		
	void Update () {
		movement = Input.GetAxis ("Horizontal"); 
		if(Input.GetButtonDown("Jump")){
			jumpPressed = true;
		}
	}
		
	void FixedUpdate(){
		rigid.velocity = new Vector2 (speed * movement, rigid.velocity.y);
		grounded = isGrounded ();  

		anim.SetBool ("Ground", grounded); 
		if((movement<0 && isFaceRight)||(movement>0 && !isFaceRight)){
			flip ();
		}
		if (jumpPressed && isGrounded ()) {
			Jump ();
		}
		anim.SetFloat ("Speed", Mathf.Abs (movement));
		anim.SetFloat("vSpeed", rigid.velocity.y);
	}

	void Jump(){
		rigid.velocity = new Vector2 (rigid.velocity.x, 0);
		rigid.AddForce (new Vector2 (0, jumpForce));
		jumpPressed = false;
	}

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