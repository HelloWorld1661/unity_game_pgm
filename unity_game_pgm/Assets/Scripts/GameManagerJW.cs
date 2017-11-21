using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Data: 2017/11/13
Author: Jun
*/
public class GameManagerJW : MonoBehaviour {
	/*Persistent data*/
	private int score = 0;
	private int getRight = 0;
	private int getWrong = 0;
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

	public void setUserName(string n){
		this.userName = n;
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
		this.getRight += 1;
	}

	public void LoseScore(){
		this.score -= 2;
		this.getWrong += 1;
	}

}
