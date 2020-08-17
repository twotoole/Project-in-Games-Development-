using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class thirdPersonMovementv2 : MonoBehaviour
{
//used in game
//https://www.youtube.com/watch?v=p-3S73MaDP8 <---- video about unity new imput system
//Brackeys


// first audio source is used when jumping
    public AudioSource audioData;
// second is for when the north button is held
    public AudioSource audioData2;

	public GameObject sun;

    public float maxEnergy = 1;

    public float energy = 1;
    public float energyIncrease = 0.01f;
    public float energyDecrease = 0.1f;
//said image represents the amount of energy left
    public Image bar;
    public Image maxBar;


// player character controller
    public CharacterController controller; 
    public Transform cam;
    public float speed = 6f;

// amount speed increased by when trigger is held
    float movementSpeedIncrease;
    

    PlayerControls controls;
    Vector2 move;
    Vector3 direction;

    float turnSmoothTime = 0.1f;
    float turnSMoothVelocity;


    float originalJumpSpeed;
    public float jumpSpeed = 1f;
    public float jumpSpeedIncrease;
    //gravity needs to be lower than jump speed
    public float gravity = 0.9f;


    bool isJumping = false;
    bool isSpeaking = false;

    void Awake()
    {
        controls = new PlayerControls();

    //when the movement control is activated read the x,y values
        controls.gameplay.Movement.performed += ctx => move = ctx.ReadValue<Vector2>();
    //when finished moving set move vector to 0
        controls.gameplay.Movement.canceled += ctx => move = Vector2.zero;


        controls.gameplay.Jump.started += ctx => isJumping = true;
        controls.gameplay.Jump.canceled += ctx => isJumping = false;

        controls.gameplay.Speak.started += ctx => isSpeaking = true;
        controls.gameplay.Speak.canceled += ctx => isSpeaking = false;

        controls.gameplay.SpeedUp.performed += ctx => movementSpeedIncrease = ctx.ReadValue<float>();

    }

    void OnEnable()
    {
        controls.gameplay.Enable();
    }

    // Start is called before the first frame update
    void Start()
    {
        originalJumpSpeed = jumpSpeed;
    }

    // Update is called once per frame
    void Update()
    {  
        Gravity();
        Jump();
        energyBar();
        speaking();

        // takes x,y from movement vector from controls and creates a direction vector
        float horizontal = move.x;
        float vertical = move.y;
        direction = new Vector3(horizontal, 0f, vertical).normalized;        

        if (direction.magnitude >= 0.1f)
        {
            //code from linked video
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSMoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);


            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

        
            controller.Move(moveDir.normalized * speed * (1+movementSpeedIncrease) * Time.deltaTime);
        }

    }

    public void Jump()
    {
        //while button is held player is in a jumping state making for a jetpack style jump
        if(isJumping == true && energy>0)
        {
            audioData.mute = false;
            jumpSpeed += (jumpSpeedIncrease * (Mathf.Sin(jumpSpeed) * 10));
            controller.Move(Vector3.up * jumpSpeed * Time.deltaTime);
            energy -= energyDecrease;
        }

        if(isJumping == false)
        {
            audioData.mute = true;
            jumpSpeed = originalJumpSpeed;
        }
    }

//scales energy bar based on amount if energy
    void energyBar(){
        if(energy<maxEnergy){
            energy+=energyIncrease;
        }
        bar.transform.localScale = new Vector3(1f, energy, 1f);
        maxBar.transform.localScale = new Vector3(1f, maxEnergy, 1f);
    }

//constantly moves character down
    void Gravity()
    {
        controller.Move(Vector3.down * gravity * Time.deltaTime);
    }

    void speaking()
    {
        if(isSpeaking==true)
        {
            audioData2.mute = false;
        }
        if(isSpeaking==false)
        {
            audioData2.mute = true;
        }
    }

}
