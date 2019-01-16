using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

	static Music instance = null;

	//SETS MUSIC
	private void Awake(){
		if (instance != null) {
			Destroy (gameObject);

		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}

	//TOGGLES THE SOUND OFF AND ON 
	public void ToggleSound(){
		if (PlayerPrefs.GetInt ("Muted", 0) == 0) {
			//SET VOL TO ON  
			PlayerPrefs.SetInt ("Muted", 1);
		} else {
			//SET VOL TO OFF 
			PlayerPrefs.SetInt ("Muted", 0);
		}

	}


}
