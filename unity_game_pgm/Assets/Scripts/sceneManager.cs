using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour {
	private int currentSceneIndex = 0;

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
	}

	public void goToInstruction(){
		SceneManager.LoadScene ("Instruction");
	}

	public void goToSettings(){
		SceneManager.LoadScene ("Settings");
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
	public void quitGame(){
		Application.Quit ();
	}
}