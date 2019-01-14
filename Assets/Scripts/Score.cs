using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int score = 0;
	public Text displayScore;

	private void Update(){
		displayScore.text = "SCORE: " + score.ToString ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Enemy")) {
			score++;
		}
	}
}
