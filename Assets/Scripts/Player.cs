using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	//MOVEMENT
	private Vector2 targetPosition;
	public float yMovement;
	public float speed;
	//SCREEN
	public float screenMaxHeight;
	public float screenMinHeight;
	//EFFECTS 
	public int health = 3;
	public GameObject effect;
	private Shake shake;
	//GAME PLAY
	public Text displayHealth;
	public GameObject endPanel;
	private bool gameOver = false;
	private Score score;
	private int scoreCount;


	void Start(){
		shake = GameObject.FindGameObjectWithTag ("ScreenShake").GetComponent<Shake> ();
	}

	private void Update() {
		displayHealth.text = "LIVES: " + health.ToString ();

		if (health <= 0) {
			EndGame ();
		}
		//MOVEMENT 
		transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
		if (Input.GetMouseButtonDown (0)) {
			if (Input.mousePosition.y > Screen.height / 2 && transform.position.y < screenMaxHeight) {
				shake.CamShake ();
				Instantiate (effect, transform.position, Quaternion.identity);
				targetPosition = new Vector2 (transform.position.x, transform.position.y + yMovement);
			} else if (Input.mousePosition.y < Screen.height / 2 && transform.position.y > screenMinHeight) {
				shake.CamShake ();
				Instantiate (effect, transform.position, Quaternion.identity);
				targetPosition = new Vector2 (transform.position.x, transform.position.y - yMovement);
			}

		}
	}


	public void EndGame (){
		gameOver = true;
		Destroy (gameObject);
		endPanel.SetActive (true);
	}
		

}
