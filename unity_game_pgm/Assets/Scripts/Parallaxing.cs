using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour {

	public Transform[] bgs;					// bgs to Behaviour parallaxed
	private float[] parallaxScales;			// proportion of cam's mvmt to mv bgs by
	private float smoothing = 1f; 			// set above 0

	private Transform cam;					// ref to main cam's transform
	private Vector3 prevCamPos; 			// 3 for xyz vals - stores position of cam in prev frame

	/* Awake is called before Start()
	 * but after gameObj are setup
	 * great for references
	 */
	void Awake() {
		cam = Camera.main.transform;
	}

	// Use this for initialization
	void Start () {
		prevCamPos = cam.position;

		parallaxScales = new float[bgs.Length];

		// assigning coressponding parallax scales
		for (int i=0; i<bgs.Length; i++) {
			parallaxScales[i] = bgs[i].position.z * -1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		// for each bg
		// parallax is opp of cam mvmt to create effect
		for (int i=0; i<bgs.Length; i++) {
			float parallax = (prevCamPos.x - cam.position.x) * parallaxScales[i];

			float bgTargetPosX = bgs[i].position.x + parallax;

			Vector3 bgTargetPos = new Vector3 (bgTargetPosX, bgs[i].position.y, bgs[i].position.z);

			// fade b/w curr & target pos using Lerp
			// Time.deltaTime converts frames to seconds
			bgs[i].position = Vector3.Lerp(bgs[i].position, bgTargetPos, smoothing * Time.deltaTime);
		}
		prevCamPos = cam.position;
	}
}
