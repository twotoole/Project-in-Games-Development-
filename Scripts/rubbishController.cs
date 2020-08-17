using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rubbishController : MonoBehaviour {
//not in game

//transform of area you want the objects to spawn
	public Transform spawnArea;
//array for all objects
    Transform[] trash;

	// Use this for initialization


	void Start () {

//counts all the children of this game object trash is set to an array of that size
//loop assining all array spaces to the objects in the gameworld
		int count;
		count = this.gameObject.transform.childCount;
		trash = new Transform[count];

		 for(int i=0;i<count;i++)
			{
				trash[i] = this.gameObject.transform.GetChild(i);
			}
		
		//instantiate between 0 and trash.Length pieces of rubbish
		for(int j=0;j<Mathf.Floor(Random.Range(0, trash.Length));j++)
			{
				Instantiate (trash[Random.Range(0,trash.Length)], spawnArea.position +
				new Vector3(Random.Range(-100,100), 10f, Random.Range(-100,100)), spawnArea.rotation);
			}
	}
	
	// Update is called once per frame
	void Update () {
	}



}
