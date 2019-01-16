using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Instructions : MonoBehaviour {

	public GameObject instructionsPanel;

	public void openPanel(){
		if (instructionsPanel != null) {
			instructionsPanel.SetActive (true);
		}

	}

	public void closePanel(){
		instructionsPanel.SetActive (false);
	}

}
