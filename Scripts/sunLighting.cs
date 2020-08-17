using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunLighting : MonoBehaviour {
//used in game
//rotates main directional light to mimic sun movement

	public float timer;
	public float speed = 1;

	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(timer>360){
			timer=0;
		}

		timer+= speed;

		transform.rotation = Quaternion.Euler(timer, 0, 0);
	}
}
