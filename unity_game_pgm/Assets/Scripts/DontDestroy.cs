using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {
	void Awake (){
		//Check how many obbjects are in the scene that are tagged with "BackgroundMusic".
		GameObject[] objs = GameObject.FindGameObjectsWithTag("BackgroundMusic");
		if (objs.Length > 1) { // if it found more than one object it, 
			Destroy (this.gameObject);    //then destroy the Objects are tagged with same "BackgroundMusic".
		} else { // if only one on current scene.
			DontDestroyOnLoad(this.gameObject); // then tell this object to stay alive all the time.
		}
	}
}