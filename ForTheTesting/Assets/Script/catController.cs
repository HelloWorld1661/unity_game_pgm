using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catController : MonoBehaviour {

	Animator anim;

	private float moveSpeed = 3.0f;
	private float rotatinSpeed = 3.0f;
	private float range = 1.0f;
	public Transform target;
	private Transform myTransform;
	public GameObject Lover;

	// Awake is called when the script instance is being loaded
	//Awake is called after all objects are initialized so you can 
	//safely speak to other objects or query them using eg. GameObject.FindWithTag.
	void Awake(){
		myTransform = transform;
		target = GameObject.FindWithTag("Player").transform; //the player
	}

	// Use this for initialization
	void Start () {
		if (anim == null) {
			anim = GetComponent<Animator> ();
		}

		transform.rotation = Quaternion.Euler (0, 0, 0); //reset the rotation on the x y & z.


	}
	
	// Update is called once per frame
	void Update () {}

	//Update is called every fixed framerate frame
	void FixedUpdate(){
		movement();
	}
	//Sent when an incoming collider makes contact with this object's collider
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			anim.SetBool ("catchMyHeart", true);
			transform.position = new Vector2 (transform.position.x + Random.Range(-2.0f, 2.0f), transform.position.y + Random.Range(-2.0f, 2.0f));
			Instantiate(Lover,transform.position,Quaternion.identity); //generate the exploder animation object.
		}
	}

	// AI movement
	void movement(){
		float distance = Vector3.Distance(myTransform.position, target.position); //get the distance between my position and targe position.
		//directionToFace  =     destion    -     source
		Vector3 directionToFace = target.position - myTransform.position; // find the specified diretion of rotation.
		float angle = Mathf.Atan2(directionToFace.y,directionToFace.x) * Mathf.Rad2Deg;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward); // rotate "angle" degrees around Z axis.
		//transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, Time.time * speed);
		//rotate to look at the player
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotatinSpeed);

		//move towards the player
		if (distance > range) {
			myTransform.position += myTransform.right * moveSpeed * Time.deltaTime;
		}
	}
		





















	void movement1(){
		float distance = Vector3.Distance(myTransform.position, target.position); //get the distance between my position and targe position.
		Vector3 relativePos = target.position - myTransform.position; // find the specified diretion of rotation.
		Quaternion toRotation = Quaternion.LookRotation (relativePos); // passing through your direction to face.
		Quaternion fromRotaion = myTransform.rotation; 
		if(distance > range){
			myTransform.rotation = Quaternion.Slerp (fromRotaion,toRotation,Time.deltaTime * rotatinSpeed);
		}
	}

	void movement2(){
		Vector3 directionToFace = target.position - myTransform.position; // find the specified diretion of rotation.
		Quaternion toRotation = Quaternion.LookRotation (directionToFace, Vector3.right); // passing through your direction to face.
		Quaternion fromRotaion = myTransform.rotation; 
		myTransform.rotation = Quaternion.Slerp (fromRotaion,toRotation,Time.deltaTime * rotatinSpeed);
	}
}
