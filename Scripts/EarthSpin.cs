using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthSpin : MonoBehaviour
{
    //used in game
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

	void Update () 
    {
		this.gameObject.transform.Rotate(0.1f, 0f, 0.1f, Space.Self);
	}
}
