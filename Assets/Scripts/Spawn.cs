using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {


	public GameObject[] enemyPatterns;
	public float startTime;
	private float timeSpawn;

	// Update is called once per frame
	private void Update () {
		if (timeSpawn <= 0) {
			int rand = Random.Range (0, enemyPatterns.Length);
			Instantiate (enemyPatterns[rand], transform.position, Quaternion.identity);
			timeSpawn = startTime;
		} else {
			timeSpawn -= Time.deltaTime;
		}
	}
}
