using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour {

	private Music music;
	public Button toggleButton;
	public Sprite onButton;
	public Sprite offButton;

	void Start(){
		music = GameObject.FindObjectOfType<Music> ();
		UpdateIcon ();
	}

	public void PauseMusic(){
		music.ToggleSound ();
		UpdateIcon ();
	}

	//SETS AUDIO AND ICON CHANGE
	void UpdateIcon(){
		if (PlayerPrefs.GetInt ("Muted", 0) == 0) {
			AudioListener.volume = 1;
			toggleButton.GetComponent<Image> ().sprite = onButton;
		} else {
			AudioListener.volume = 0;
			toggleButton.GetComponent<Image> ().sprite = offButton;
		}
	}


}
