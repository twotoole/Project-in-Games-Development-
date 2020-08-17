using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void  OnTriggerExit(Collider other){
        if(other.gameObject == player){
        player.GetComponent<thirdPersonMovementv2>().maxEnergy += 0.3f;
        player.GetComponent<thirdPersonMovementv2>().energyIncrease *= 2f;


        Destroy(this.gameObject);
        }
    }
}
