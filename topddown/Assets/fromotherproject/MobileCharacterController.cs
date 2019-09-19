using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCharacterController : MonoBehaviour
{
    public CharacterController characterController;
    public Vector3 moveDirection;
    // public Joystick movementInput;
    //public Joystick rotInput;
    public float moveSpeed;
    public float turnSpeed; 
    public Joystick joystick;
    // public float rotSpeed; 


   
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded)
        {
            var horizontal = joystick.Horizontal;
            var vertical = joystick.Vertical;
            //var movement = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
            moveDirection = new Vector3(horizontal, 0, vertical);
            moveDirection *= moveSpeed;
            moveDirection = transform.TransformDirection(moveDirection);
            characterController.Move(moveDirection * Time.deltaTime);
        }
        
        //   transform.LookAt(transform.position + movement); 
        // var horizontal = joystick.Horizontal * 100;
        //  var vertical = joystick.Vertical *100;
        //   var movement = new Vector3(joystick.Horizontal, 0, joystick.Vertical);


        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(transform.position - tpos), Time.fixedDeltaTime * turnSpeed);
        // transform.rotation = Quaternion.LookRotation(movement);
        // Quaternion newDirection = Quaternion.LookRotation(movement);
        //transform.rotation = Quaternion.Lerp(transform.rotation, movement, turnSpeed * Time.deltaTime);


        // jumpSpeed = 10;
        //characterController.SimpleMove(movement * Time.deltaTime * moveSpeed);
    }
}
