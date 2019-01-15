﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

	static Music instance = null;

	private void Awake(){
		if (instance != null) {
			Destroy (gameObject);

		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}

	public void ToggleSound(){
		if (PlayerPrefs.GetInt ("Muted", 0) == 0) {
			//set to on 
			PlayerPrefs.SetInt ("Muted", 1);
		} else {
			// set to off
			PlayerPrefs.SetInt ("Muted", 0);
		}

	}


}
