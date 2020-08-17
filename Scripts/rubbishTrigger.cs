using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubbishTrigger : MonoBehaviour
{
//used in game
// when an object hits this it calls the createNewPieceOfRubbish() to repopulate the world with rubbish
//as the sun spins around it will hit this once a cycle
   public GameObject rubbishControl;
    // Start is called before the first frame update
    void awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
            rubbishControl.GetComponent<trashCreation>().createNewPieceOfRubbish();
    }
}
