using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Mute : MonoBehaviour {

	private Toggle tog;
//	private float prevVol;

	void Awake () {
		tog = GetComponentInChildren<Toggle>();
		if (AudioListener.volume == 0f) {
			tog.isOn = true;
//			prevVol = 0.7f;
		} else {
//			prevVol = AudioListener.volume;
		}
	}

	public void onMute() {
		if (tog.isOn) {
			AudioListener.volume = 0f;
		} else {
//			AudioListener.volume = prevVol;
			AudioListener.volume = sceneManager.volumeLevel;
		}
	}
}
