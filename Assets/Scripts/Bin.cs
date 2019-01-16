using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin : MonoBehaviour {

	public float life;

	//REMOVES EXCESS GAME OBJECTS TO REDUCE OVERLOAD
	private void Start(){
		Destroy (gameObject, life);
	}
}
