using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class pickup : MonoBehaviour {
//not used in final game

//UI text object
	public Text text;

//position you want object to be placed on player
	public GameObject hands;
	public GameObject heldItem;
	bool isHolding = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		pickUp();
		drop();

	}

//cast a ray forward
	void pickUp(){
		RaycastHit hit;
		Physics.Raycast(transform.position, transform.forward, out hit, 5.0f);
		
		//if the collider the ray hit is tagged pickupable and the player is not holding an item
		if (hit.collider) 
			{
			if (hit.collider.tag=="pickupable" && isHolding == false) 
				{
					//ui text displays:
					text.text = "press e to pick up item";
					//if the e key is pressed, moves the collided object to position of players hands
					//sets the hands to be a parent of the gameobject, so it will move with the player
					if(Input.GetKeyDown(KeyCode.E)){
						hit.collider.gameObject.transform.position = hands.transform.position;
						hit.collider.gameObject.transform.SetParent(hands.transform);
						hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = true;
						heldItem = hit.collider.gameObject;
						isHolding = true;
					}
				}
			}
		else
			{
				text.text = "";	
			}
	}

	void drop(){

		if(isHolding == true)
		{
			//turns back on movement for the object and removes child status
			if(Input.GetKeyDown(KeyCode.Q))
			{
				heldItem.GetComponent<Rigidbody>().isKinematic = false;
				heldItem.transform.parent = null;
				isHolding = false;
			}	
		}

	}

}
