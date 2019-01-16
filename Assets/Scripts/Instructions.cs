using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Instructions : MonoBehaviour {

	public GameObject instructionsPanel;

	//OPENS INSTRUCTION PANEL 
	public void openPanel(){
		if (instructionsPanel != null) {
			instructionsPanel.SetActive (true);
		}

	}
	//CLOSE INSTRUCTION PANEL
	public void closePanel(){
		instructionsPanel.SetActive (false);
	}

}
