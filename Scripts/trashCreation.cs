using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashCreation : MonoBehaviour
{
    //used in game
    
    //transform of area you want the objects to spawn
	public Transform spawnArea;
    //array for all objects
    Transform[] trash;

    //contorls the size range in the instantiated objects
    public float size = 1;
    //controls the amount of rubbish that can be generated
    public int amount =1;


    // Start is called before the first frame update
    void Start()
    {
        //counts the amount of objects used for new object generation that are set as a child of this gameobject
        //adds them to an array
        int count;
		count = this.gameObject.transform.childCount;
		trash = new Transform[count];

    	for(int i=0;i<count;i++)
		{
			trash[i] = this.gameObject.transform.GetChild(i);
		}

        // createNewPieceOfRubbish();
    }

    // Update is called once per frame
    void Update()
    {

    }

//previous version
    // public void createNewPieceOfRubbish(){
		
    //     // trans = trash;
	//  	// Vector3 pos = new Vector3(1f, 1f, 1f);

		
	//  	// Instantiate(newTransform1, new Vector3(1f, 1f, 1f), Quaternion.identity);


    //     GameObject obj = new GameObject();
    //     obj.tag = "pickupable";
    //     obj.AddComponent<Rigidbody>();
    //     obj.transform.position = new Vector3(1f, 1f, 1f);
    //     obj.AddComponent<BoxCollider>();

  	//  	Transform newTransform1;
    //     newTransform1 = Instantiate(trash[0], transform.position, transform.rotation);
	//  	Transform newTransform2;
    //     newTransform2 = Instantiate(trash[1], transform.position, transform.rotation);

        


    //    // Instantiate(obj, new Vector3(1f, 1f, 1f), Quaternion.identity);
    //     newTransform1.SetParent(obj.transform);
    //     newTransform2.SetParent(obj.transform);

    //     newTransform1.localScale = new Vector3(0.2f, 0.2f, 0.2f);
    //     newTransform2.localScale = new Vector3(0.2f, 0.2f, 0.2f);

    //     newTransform1.position = obj.transform.position + new Vector3(2f, 3f, 1f);
    //     newTransform2.position = obj.transform.position + new Vector3(1f, 2f, 2f);
	//  }


//function that instantiates a random number of objects combine as new objects with random colours
    public void createNewPieceOfRubbish(){  

    //creates the number of new objects that will be instantiated
    float number = Mathf.Floor(Random.Range(trash.Length, trash.Length*amount));   


    for(int i=0; i<number;i++)
    {
        //new empty gameobject
        GameObject obj = new GameObject();
        //tagg so the player can interact with it
        obj.tag = "pickupable";
        //add component so player can interact with it
        obj.AddComponent<Rigidbody>();
        //generate random position within defined area to spawn object
        obj.transform.position = spawnArea.position + new Vector3(
        Random.Range(spawnArea.transform.position.x-spawnArea.transform.localScale.x/2, spawnArea.transform.position.x+spawnArea.transform.localScale.x/2),
        spawnArea.transform.position.y,
        Random.Range(spawnArea.transform.position.z-spawnArea.transform.localScale.z/2,spawnArea.transform.position.x+spawnArea.transform.localScale.z/2));
        //add component so player can interact with it
        obj.AddComponent<BoxCollider>();
        //add script so if the object doesnt land in a appropriate area is will fall and be destroyed
        obj.AddComponent<destroyObject>();


        //create a new object with 1-10 pre made objects that are now in the array of objects
        for(int j=0;j<Mathf.Floor(Random.Range(1,10));j++)
        {
            //makes new transform
            Transform newTransform;
            //new transform is an instantiated object form the array
            newTransform = Instantiate(trash[(Random.Range(0, trash.Length))], transform.position, transform.rotation);
            //sets it as a child of the game object with the appropriate properties so it will be interactable
            newTransform.SetParent(obj.transform);
            //change scale of this instantiated transform
            newTransform.localScale = new Vector3(Random.Range(0.1f, 1f*size), Random.Range(0.1f, 1f*size), Random.Range(0.1f, 1f*size));
            //set random position within the generated gameobject
            newTransform.position = obj.transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(0f, 1f), Random.Range(-1f, 1f));
            //set random rotation
            newTransform.Rotate(Random.Range(-180f, 180f),Random.Range(-180f, 180f), Random.Range(-180f, 180f), Space.Self);

            //randomize each transform's colour
            Component[] rend;
            rend = GetComponentsInChildren<Renderer>();

            foreach (Renderer r in rend)
            {
                r.material.SetColor("_Color", new Vector4(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f)));
            }
            

        }



            
    
    }
    
    
    }   


}
