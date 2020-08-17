using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour {
//not used in final game
//https://www.youtube.com/watch?v=7nxpDwnU0uU <-- all code taken from here
//Make a Third Person Camera and Movement Controller in 7 Minutes | Unity Tutorial (or Download)
//Stephen Barr


	public float RotationSpeed = 1;
	public Transform Target, Player;
	float mouseX, mouseY;

	// Use this for initialization
	void Start () {
		// Cursor.visible = false;
		// Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {

		cameraControl();

	}

	void cameraControl()
	{
		// get movement direction from mouse clamped between 2 values
		mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
		mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
		mouseY = Mathf.Clamp(mouseY, -10, 60);


		transform.LookAt(Target);

//if left shift is held the target (player) rotates independantly from camera movement
		if(Input.GetKey(KeyCode.LeftShift)){
			
			Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);

		}
		else{
			Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
			Player.rotation = Quaternion.Euler(0, mouseX, 0);
		}
	}
	
}
