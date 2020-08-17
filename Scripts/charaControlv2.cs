using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charaControlv2 : MonoBehaviour {
//not in final game
//https://docs.unity3d.com/ScriptReference/CharacterController.Move.html

    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    public float maxFuel = 100.0f;
    public float fuel = 100f;


    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
        }
        
        boosterControl();

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);

    }


//my code
//if the button that has been assigned to jump is being pressed and the fuel level is greater than 1
//decrease fuel and increase player height
    void boosterControl()
    {
        if(fuel>1)
        {
            if (Input.GetButton("Jump"))
            {
                fuel -= 10f;
                moveDirection.y = jumpSpeed;
            }
        }

        if(fuel <= maxFuel){
            fuel+=0.2f;
        }
    }

}
