using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI; 
using UnityEngine;
using System;

/*
 * Date: 2017/11/23
 * Author: Jun
*/

public class Timer : MonoBehaviour {
	private string timeTargetFormat; // get time fotmat-> min:sec -> 00 : 00
	private bool isEnd = false; // Is the countdown timer end? (YES -> true; NO -> false.) default value: false
	public Text timerText;

	// Update is called once per frame
	void Update () {
		doCountdown ();
	}

	public void doCountdown(){
		if (GameManagerJW.Instance.getIsTimer()) { // if the timer start
			setTimeTargetFormat (GameManagerJW.Instance.getTimeTarget());
			timerText.text = "Time: " + getTimeTargetFormat (); //update timer text field per frame.
			if (GameManagerJW.Instance.getTimeTarget() > 0) { //if timer is not end
				float timeTarget = GameManagerJW.Instance.getTimeTarget();
				timeTarget -= Time.deltaTime;
				GameManagerJW.Instance.setTimeTarget (timeTarget);    

				setTimeTargetFormat (GameManagerJW.Instance.getTimeTarget()); //update the timer formate
				this.isEnd = false;
			} else {
				this.isEnd = true;
			}
		}
	}

	public void setTimeTargetFormat(){
		TimeSpan timeSpan = TimeSpan.FromSeconds (GameManagerJW.Instance.getTimeTarget()); 
		this.timeTargetFormat = string.Format ("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds); 
	}

	public void setTimeTargetFormat(float myTimeTarget){
		TimeSpan timeSpan = TimeSpan.FromSeconds (myTimeTarget); 
		this.timeTargetFormat = string.Format ("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds); 
	}

	public string getTimeTargetFormat(){
		return this.timeTargetFormat;
	}

	public void printCountdown(){
		print (getTimeTargetFormat());
	}

	public void setIsEnd(bool countdownEnd){
		this.isEnd = countdownEnd;
	}

	public bool getIsEnd(){
		return this.isEnd;
	}
}