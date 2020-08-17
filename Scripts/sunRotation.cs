using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunRotation : MonoBehaviour {
//used in game
//rotates sun around a gameobject

	public GameObject floor;
	public float speed = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(floor.transform.position, Vector3.right, speed);
	}
}
