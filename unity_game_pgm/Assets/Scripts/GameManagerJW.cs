using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

/*
Data: 2017/11/13
Author: Jun
*/
public class GameManagerJW : MonoBehaviour {
	/*Persistent data*/
	private int score = 0;
	private int getRight = 0;
	private int getWrong = 0;
	private float timeTarget = 60.0f;// RP changing for faster game play (IMPORTANT: make sure to chnage value under resetAllData() as well) //Default time: 10mins = 600s
	private bool isTimer = false; // Is it to start the timer? (YES -> true; NO -> false.) default value: false
	private bool isGameStart = false;
	private bool isTimerEnd =false;
	private bool isResetData = false;
	private bool isInputEmpty = false;
	private string userName;
	public static GameManagerJW Instance = null; //Static instance of sceneManager which allows it to be accessed by any other script.

	public void Awake(){
		if (Instance == null) {    //Check if instance already exists
			DontDestroyOnLoad (this.gameObject);    //Sets this to not be destroyed when reloading scene
			Instance = this;    //if not, set instance to this
		} 
		//If instance already exists and it's not this:
		else{
			//Then destroy this. This enforces our singleton pattern, 
			//meaning there can only ever be one instance of a GameManager.
			Destroy (this.gameObject);
		}
	}
	public void setInputIsEmpty(){
		this.isInputEmpty = true;
	}
	public void setInputIsNotEmpty(){
		this.isInputEmpty = false;
	}
	public bool getIsInputEmpty(){
		return this.isInputEmpty;
	}



	public void ResetData(){
		this.isResetData = true;
	}

	public void notReSetData(){
		this.isResetData = false;
	}

	public bool getResetData(){
		return this.isResetData;
	}

	// RP 2017-11-27
	public void increaseTime(float t) {
		timeTarget += t;
	}
		
	public bool getIsTimerEnd(){
		if(timeTarget == 0 || timeTarget < 0){
			isTimerEnd = true;
		}
		return isTimerEnd;
	}
	public void resetAllData(){
		score = 0;
		timeTarget = 60.0f;
		isTimer = false;
		isGameStart = false;
		isTimerEnd = false;
		userName = "Player Name";
		isResetData = false;
	}
	public void setGameIsStart(){
		this.isGameStart = true;
	}

	public void setGameIsNotStart(){
		this.isGameStart = false;
	}

	public bool getIsGameStart(){
		return this.isGameStart;
	}

	public bool getIsTimer(){
		return this.isTimer;
	}

	public void stopTimer(){
		this.isTimer = false;
	}

	public void startTimer(){
		this.isTimer = true;
	}

	public void setTimeTarget(float myTimeTarget){
		this.timeTarget = myTimeTarget;
	}
	public float getTimeTarget(){
		return this.timeTarget;
	}


	/**/
	public void setScore(int s){
		this.score = s;
	}

	public void setRight(int r){
		this.getRight = r;
	}

	public void setWrong(int w){
		this.getWrong = w;
	}



	/**/
	public int getScore(){
		return this.score;
	}

	public int getRightAns(){
		return this.getRight;
	}

	public int getWrongAns(){
		return this.getWrong;
	}
	public void setUserName(string n){
		this.userName = n;
	}
	public string getUserName(){
		return this.userName;
	}

	/**/
	public void increaseScore (int s){
		this.score += s;
	}
	public void increaseScore (){
		increaseScore (1);
	}


	public void increaseRight(int r){
		this.getRight += r;
	}
	public void increaseRight(){
		increaseRight (1);
	}

	public void increaseWrong(int w){
		this.getWrong += w;
	}
	public void increaseWrong(){
		increaseWrong (1);
	}


	public void DoubleScore(){
		this.score *= 2;
//		this.getRight += 1; // RP called by other method
	}

	public void LoseScore(){
		this.score -= 2;
//		this.getWrong += 1; // RP called by other method
	}
}