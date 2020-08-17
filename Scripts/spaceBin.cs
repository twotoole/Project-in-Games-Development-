using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceBin : MonoBehaviour {
//used in game

//destroys objets with appropriate tag on collision

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "pickupable"){
			Destroy(col.gameObject);
		}

	}
}
