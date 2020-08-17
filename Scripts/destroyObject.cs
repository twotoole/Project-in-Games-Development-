using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{//used in final game

//if the object this is assigned to is lower than a certain threshold the object will be destroyed
//this is to make sure that as the pieces of rubbish are constantly spawing if they miss the gamespace they will fall and be deleted
    public float pos = -50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.transform.position.y<pos)
        {
            Destroy(this.gameObject);
        }
    }
}
