﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
Data: 2017/11/13
Author: Jun
*/
public class sceneManager : MonoBehaviour {
	private int currentSceneIndex = 0;
	public Slider volSlider;
	public static float volumeLevel;

	void Awake() {
		if (AudioListener.volume != 0f) {
			volumeLevel = AudioListener.volume;
		}
	}

	public void setCurrentScenceIndex(int index){
		this.currentSceneIndex = SceneManager.GetActiveScene().buildIndex +index;
	}

	public void setCurrentScenceIndex(){
		this.currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
	}

	public int getCurrentScenceIndex(){
		setCurrentScenceIndex ();
		return this.currentSceneIndex;
	}

	public void goToMenu(){
		SceneManager.LoadScene ("Menu");
		Time.timeScale = 1.0f;
	}

	public void goToHighScores(){
		SceneManager.LoadScene ("GameEnd");
	}

	public void goToTutorials(){
		SceneManager.LoadScene ("Tutorials");
	}

	public void goToInstruction(){
		SceneManager.LoadScene ("Instructions");
	}

	public void goToSettings(){
		SceneManager.LoadScene ("Settings");
	}

	public void OnVolChanged() {
		AudioListener.volume = volSlider.value;
		volumeLevel = volSlider.value;
		Mute.tog.isOn = false;
	}

	public void restartCurrentScene(){
		SceneManager.LoadScene (getCurrentScenceIndex());
	}

	public void goToNextScene(){
		SceneManager.LoadScene (getCurrentScenceIndex()+1);
	}

	public void goToLastScene(){
		SceneManager.LoadScene (getCurrentScenceIndex()-1);
	}

	public void goToFirstScene(){
		SceneManager.LoadScene ("firstScene");
	}

	public void startGameTimer(){
		GameManagerJW.Instance.startTimer ();
	}

	public void ResetData(){
		GameManagerJW.Instance.ResetData ();
		PlayerPrefs.DeleteAll();
	}

	public void quitGame(){
		Application.Quit ();
	}
}