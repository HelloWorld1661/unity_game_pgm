using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreType : MonoBehaviour {

	public Text TypeText;
//	public static ScoreType Instance = null;
	private string[] types = {"M","O","N"};
	public static string Type;

	// Use this for initialization
	void Awake () {
		Type = types [Random.Range (0, 3)];
		TypeText.text = Type;
	}
}
