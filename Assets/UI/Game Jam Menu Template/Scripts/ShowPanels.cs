﻿using UnityEngine;
using System.Collections;

public class ShowPanels : MonoBehaviour {

	public GameObject optionsPanel;	
	public GameObject creditsPanel;	
	public GameObject optionsTint;							//Store a reference to the Game Object OptionsTint 
	public GameObject menuPanel;							//Store a reference to the Game Object MenuPanel 
	public GameObject pausePanel;							//Store a reference to the Game Object PausePanel 
	//
	//public GameObject ESCButton;
	//

	//Call this function to activate and display the Options panel during the main menu
	public void ShowOptionsPanel()
	{
		optionsPanel.SetActive(true);
		optionsTint.SetActive(true);
	}

	//Call this function to deactivate and hide the Options panel during the main menu
	public void HideOptionsPanel()
	{
		optionsPanel.SetActive(false);
		optionsTint.SetActive(false);
	}

	//Call this function to activate and display the Options panel during the main menu
	public void ShowCreditsPanel()
	{
		creditsPanel.SetActive(true);
		optionsTint.SetActive(true);
	}

	//Call this function to deactivate and hide the Options panel during the main menu
	public void HideCreditsPanel()
	{
		creditsPanel.SetActive(false);
		optionsTint.SetActive(false);
	}

	//Call this function to activate and display the main menu panel during the main menu
	public void ShowMenu()
	{
		menuPanel.SetActive (true);
	}

	//Call this function to deactivate and hide the main menu panel during the main menu
	public void HideMenu()
	{
		menuPanel.SetActive (false);
		//ESCButton.SetActive(true);
	}
	
	//Call this function to activate and display the Pause panel during game play
	public void ShowPausePanel()
	{

		if(pausePanel){

		pausePanel.SetActive (true);
		optionsTint.SetActive(true);
		}
	}

	//Call this function to deactivate and hide the Pause panel during game play
	public void HidePausePanel()
	{

		if(pausePanel){
		pausePanel.SetActive (false);
		optionsTint.SetActive(false);
		}
	}
}
