using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Mute : MonoBehaviour {

	public static Toggle tog;

	void Awake () {
		tog = GetComponentInChildren<Toggle>();
	}

	void Update() {
		if (AudioListener.volume == 0f) {
			tog.isOn = true;
		} else {
			tog.isOn = false;
		}
	}

	public void onMute() {
		if (tog.isOn) {
			AudioListener.volume = 0f;
		} else {
			AudioListener.volume = sceneManager.volumeLevel;
		}
	}
}
