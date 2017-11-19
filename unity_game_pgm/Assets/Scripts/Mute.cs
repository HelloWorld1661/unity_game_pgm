using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Mute : MonoBehaviour {

	private Toggle tog;
	private float prevVol;

	void Awake () {
		tog = GetComponentInChildren<Toggle>();
		prevVol = AudioListener.volume;
	}

	public void onMute() {
		if (tog.isOn) {
			AudioListener.volume = 0f;
		} else {
			AudioListener.volume = prevVol;
		}
	}
}
