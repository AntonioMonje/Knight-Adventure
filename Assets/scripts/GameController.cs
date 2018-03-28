using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public static GameController instance;        
	                
	public GameObject gameOvertext;             
	private int score = 0;                      
	public bool gameOver = false;               
	public float scrollSpeed = 0f;


	void Awake()
	{
		if (instance == null)
			instance = this;
		else if(instance != this)
			Destroy (gameObject);
	}

	void Update()
	{
		
		if (gameOver && Input.GetMouseButtonDown(0)) 
		{
			
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void YourScore()
	{
		
		if (gameOver)   
			return;
		

	}

	public void YouDied()
	{
		gameOvertext.SetActive (true);
		gameOver = true;
	}
}
