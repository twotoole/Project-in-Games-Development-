using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
public class ThirdPersonMovement : MonoBehaviour
{
//not used in game
// https://www.youtube.com/watch?v=4HpC--2iowE <---- all code from here
//Brackeys


    public CharacterController controller; 
    public Transform cam;
    public float speed = 6f;

    public float gravity = 20.0f;

    public float jump = 6.0f;
    Vector3 gravDir = Vector3.zero;

   // public float turnSmoothTime = 0.1f;
   //float turnSMoothVelocity;
   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
           // float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSMoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);


            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }


    }
}
