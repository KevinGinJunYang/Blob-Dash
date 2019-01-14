using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

	public GameObject spawn;

	// Use this for initialization
	private void Start () {
		Instantiate (spawn, transform.position, Quaternion.identity);
	}

}
