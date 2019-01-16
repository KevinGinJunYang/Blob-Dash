using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public Text scoreText;
	private Score score;

	//SHOW BEST SCORE 
	private void Start(){
		scoreText.text = "BEST: " + PlayerPrefs.GetInt ("score").ToString ();
	}

	//CHANGE TO GAME SCENE
	public void playGame(){
		SceneManager.LoadScene ("Game");
	}
}
