using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

/// <summary>
/// This script pauses the game when you press the escape key.
/// </summary>

public class PauseMenu : MonoBehaviour {
	
	public GameObject PauseUI;
	
	private bool paused = false;

	public GameObject MainMenuUI;
	
	void Start () {

		MainMenuUI = GameObject.Find ("Main Menu");
		MainMenuUI.SetActive (false);

		//makes sure that the game is not paused on startup
		paused = false;

		//finds the pause menu
		PauseUI = GameObject.Find ("Pause Menu");
	}
	
	void Update () {

		//pauses the game when the escape key is pressed
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			paused = !paused;
			MainMenuUI.SetActive (false);
		}
		
		if (paused)
		{
			PauseUI.SetActive (true);
			Time.timeScale = 0;
		}
		
		else if (!paused)
		{
			PauseUI.SetActive (false);
			Time.timeScale = 1;
		}
		
	}

	//resumes the game on button click
	public void Resume()
	{
		paused = false;
		
	}

	//restarts the level on button click
	public void Restart()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	//loads the main menu and closes the level on button click
	public void MainMenu()
	{
		MainMenuUI.SetActive (true);
	}

	//closes the game on button click
	public void Exit ()
	{
		Application.Quit();
	}
}