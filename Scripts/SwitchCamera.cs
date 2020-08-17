using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

public class SwitchCamera : MonoBehaviour
{
//used in game

 //https://forum.unity.com/threads/cinemachine-freelook-camera-and-new-input-system.773657/
 //nettamenteBoss

 //used to allow for gamepad to controll cinemachine freelook camera
 //place on cinemachine freelook camera
 //leave x and y axis names blank
 //attach itself as public gameobject


    public GameObject cinemachine;
 
    private CinemachineFreeLook freeLook;
 
    void Start()
    {
        freeLook = cinemachine.GetComponent<CinemachineFreeLook>();
 
 
    }
 
    public void Look(InputAction.CallbackContext context)
    {
 
 
        freeLook.m_XAxis.m_InputAxisValue = context.ReadValue<Vector2>().x;
        freeLook.m_YAxis.m_InputAxisValue = context.ReadValue<Vector2>().y;
 
    }
 
 
}
