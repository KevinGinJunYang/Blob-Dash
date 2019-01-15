using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int damage = 1;
	public float speed;

	public GameObject sound;

	public GameObject effect;

	private void Update(){
		transform.Translate (Vector2.left * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			Instantiate (sound, transform.position, Quaternion.identity);
			col.GetComponent<Player> ().health -= damage;
			Instantiate (effect, transform.position, Quaternion.identity);
			Destroy (gameObject);
		}
	}
}
