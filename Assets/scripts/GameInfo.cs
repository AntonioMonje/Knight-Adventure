using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInfo : MonoBehaviour {
	public Text Info;
	// Use this for initialization
	void Start () {
		Info.text = "This Game is about a knight who needs to collect all ten golden coins to get better weapons. The Goal is to collect all ten coins while avoiding the slime enemies. the game is like a mario game where the level is a puzzle and you have to go through the whole level to get all the coins. To Play the game you need to use the arrow keys to move left and right and press down on the mouse or mouse pad to jump. If you die press R to restart or if you win press r to restart.";
	}
	void OnGUI() {
		if (GUI.Button (new Rect (20, 20, 100, 50), "Menu")) {
			Application.LoadLevel (0);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
