using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	private Vector2 targetPosition;
	public float yMovement;
	public float speed;

	public float screenMaxHeight;
	public float screenMinHeight;

	public int health = 3;
	public GameObject effect;
	private Shake shake;

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

		transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

		if (Input.GetKeyDown (KeyCode.UpArrow) && transform.position.y < screenMaxHeight) {
			shake.CamShake ();
			Instantiate (effect, transform.position, Quaternion.identity);
			targetPosition = new Vector2 (transform.position.x, transform.position.y + yMovement);
		} else if (Input.GetKeyDown (KeyCode.DownArrow) && transform.position.y > screenMinHeight) {
			shake.CamShake ();
			Instantiate (effect, transform.position, Quaternion.identity);
			targetPosition = new Vector2 (transform.position.x, transform.position.y - yMovement);
		}
	}

	public void EndGame (){
		
		gameOver = true;
		Destroy (gameObject);
		endPanel.SetActive (true);
	}
		

}
