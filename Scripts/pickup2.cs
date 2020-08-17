using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class pickup2 : MonoBehaviour
{
//used in game
//made for use with Unitys new input system
 
    PlayerControls controls;


//UI text object
	public Text text;
	//ui image of no buttons can be pressed
	public Image img;
	//ui image of west button can be pressed
	public Image square;

	//position you want object to be placed on player
	public GameObject hands;
	public GameObject heldItem;
	bool isHolding = false;

        void Awake()
    {
        controls = new PlayerControls();

		//if the button labelled for Pickup is pressed perfrom the contextual function of  ObjectInterchange()
        controls.gameplay.Pickup.performed += ctx => ObjectInterchange();
    }

	void OnEnable()
    {
        controls.gameplay.Enable();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		pickUpText();
		//drop();
	}

//casts ray forward if hits a collider with approriate conditions displays button prompt images 
	void pickUpText(){
		RaycastHit hit;
		Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5.0f);

		if (hit.collider) 
			{
			if (hit.collider.tag=="pickupable" || hit.collider.tag=="interactable"  && isHolding == false) 
				{
					img.gameObject.SetActive(false);
					square.gameObject.SetActive(true);
				}
			}
		else
			{
				img.gameObject.SetActive(true);
				square.gameObject.SetActive(false);
			}
	}

	public void drop()
	{
		if(isHolding == true)
		{
				heldItem.GetComponent<Rigidbody>().isKinematic = false;
				heldItem.transform.parent = null;
				isHolding = false;
		}
	}

//cast a ray forward
    public void ObjectInterchange()
    {

		 if(isHolding == false)
		 {
	 		//if the collider the ray hit is tagged pickupable and the player is not holding an item
			RaycastHit hit;
			Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5.0f);

			if (hit.collider) 
				{
				if (hit.collider.tag=="pickupable") 
					{//the collider that has been hit with the ray is set to hands position of player and is set to kinemaitc
						hit.collider.gameObject.transform.position = hands.transform.position;
						hit.collider.gameObject.transform.SetParent(hands.transform);
						hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = true;
						heldItem = hit.collider.gameObject;
						isHolding = true;
					}
				}
		 }
		
		
		else if(isHolding == true)
		{
				heldItem.GetComponent<Rigidbody>().isKinematic = false;
				heldItem.transform.parent = null;
				isHolding = false;
		}
    }

    
}
