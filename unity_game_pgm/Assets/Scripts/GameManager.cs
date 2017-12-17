using UnityEngine;
using System.Collections;
using System.Collections.Generic;       //Allows us to use Lists. 
using System;

public class GameManager : MonoBehaviour
{

//	public static GameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
//	private BoardManager boardScript;                       //Store a reference to our BoardManager which will set up the level.
//	private int level = 3;                                  //Current level number, expressed in game as "Day 1".
//
//	//Awake is always called before any Start functions
//	void Awake()
//	{
//		//Check if instance already exists
//		if (instance == null)
//
//			//if not, set instance to this
//			instance = this;
//
//		//If instance already exists and it's not this:
//		else if (instance != this)
//
//			//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
//			Destroy(gameObject);    
//
//		//Sets this to not be destroyed when reloading scene
//		DontDestroyOnLoad(gameObject);
//
//		//Get a component reference to the attached BoardManager script
//		boardScript = GetComponent<BoardManager>();
//
//		//Call the InitGame function to initialize the first level 
//		InitGame();
//	}
//
//	//Initializes the game for each level.
//	void InitGame()
//	{
//		//Call the SetupScene function of the BoardManager script, pass it current level number.
//		boardScript.SetupScene(level);
//
//	}
//
//
//
//	//Update is called every frame.
//	void Update()
//	{
//
//	}
//




	// see <http://amalgamatelabs.com/Blog/2016/Data_Persistence/>

	[Serializable]
	public class GameDetails
	{
		public decimal XP;
		public decimal XPMultiplier;
		public decimal NextXPLevelUp;
		public int DoubleXPCost;
		public int CurrentLevel;
		public int ClickCount;
		public int BrainCount;
		public int CurrentGun;
		public int AutomationLevel;
		public DateTime? SaveDate;
		public bool ProgressBarIsFull;

		public GameDetails()
		{
			XP = 0.0M;
			XPMultiplier = 1.0M;
			NextXPLevelUp = 100.0M;
			DoubleXPCost = 2000;
			CurrentLevel = 1;
			ClickCount = 0;
			BrainCount = 0;
			CurrentGun = 0;
			AutomationLevel = 0;
			SaveDate = null;
			ProgressBarIsFull = false;
		}

		public void IncrementClickCount()
		{

		}

		public void LevelUp()
		{

		}

		public void AutomateClicksBetweenSessions()
		{

		}
	}
}