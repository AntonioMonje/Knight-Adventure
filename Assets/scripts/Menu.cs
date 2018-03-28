using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	void OnGUI() {
		if (GUI.Button (new Rect (700, 300, 200, 100), "Knight Adventure")) {
			Application.LoadLevel (1);
		}
		if (GUI.Button (new Rect (700, 500, 200, 100), "Game Info")) {
			Application.LoadLevel (2);
		
		}
		if (GUI.Button (new Rect (700, 700, 200, 100), "Exit")) {
			Exit ();
		}
	}
	public void Exit()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
