using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charaContol : MonoBehaviour {
//not used in final game
//https://www.youtube.com/watch?v=7nxpDwnU0uU
//Make a Third Person Camera and Movement Controller in 7 Minutes | Unity Tutorial (or Download)
//Stephen Barr


	public float speed;
	public float enegry = 100;

	public GameObject sun;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		enegryManagement();
		
		if(enegry>0){
		PlayerMovement();
		booster();
		}
			
		Debug.Log(enegry);
	}

// get movement direction from mouse clamped between 2 values

	void PlayerMovement(){

		//get input from pressed keys and create a movement vector with them
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		Vector3 playerMovement = new Vector3(h, 0f, v).normalized * speed * Time.deltaTime;
		transform.Translate(playerMovement, Space.Self);
		
	}

//my code
//if space is held move the player upwards
	void booster(){
		if(Input.GetKey(KeyCode.Space)){
			if(enegry > 1){
				transform.position+=new Vector3(0, 1f, 0);
				enegry-=3;
			}
		}
	}

//my code
//cast ray from play to the sun if the object hit is the sun (i.e. if the sun is not being obscured by another collider)
//increase the players energy
	void enegryManagement(){
		RaycastHit hit;
		Debug.DrawRay(transform.position, (sun.transform.position - transform.position), Color.yellow);
		Physics.Raycast(transform.position, (sun.transform.position - transform.position), out hit, Mathf.Infinity);
		
		if(hit.collider.gameObject == sun)
			{
				enegry+=2;
			}
	}
	

}
