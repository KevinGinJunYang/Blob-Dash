using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject[] enemyPatterns;
	public float startTime;
	private float timeSpawn;
	public float timeDecrease;
	public float minTime;
	public GameObject endPanel;
	private void Start()
	{
		timeSpawn = startTime;
	}

	// Update is called once per frame
	private void Update () {
		
		if (endPanel.activeSelf) {
			Destroy (gameObject);
		}

		if (timeSpawn <= 0) {
			int rand = Random.Range (0, enemyPatterns.Length);
			Instantiate (enemyPatterns[rand], transform.position, Quaternion.identity);
			timeSpawn = startTime;
			if (startTime > minTime) {
				startTime -= timeDecrease;
			}

		} else {
			timeSpawn -= Time.deltaTime;
		}
	}


}
