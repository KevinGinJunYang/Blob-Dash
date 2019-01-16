using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

	//PLAYS SCENE GIVEN 
	public void OnButtonClick(string sceneName){
		SceneManager.LoadScene (sceneName);
	}
}
