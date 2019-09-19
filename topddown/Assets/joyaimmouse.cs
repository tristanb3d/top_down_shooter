using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//this script can be found in the Component section under the option Intro PRG/Mouse Look
//[AddComponentMenu("Intro PRG/RPG/PLAYER/Mouse Look")]
public class joyaimmouse : MonoBehaviour
{
    //Before you write this section please scroll to the bottom of the page
    #region Variables
    //[Header("Rotational Axis")]
    [Header("Rotational Axis")]
    //create a public link to the rotational axis called axis and set a defualt axis
    public RotationalAxis axis = RotationalAxis.JoyX;
    //[Header("Sensitivity")]
    [Header("Sensitivity")]
    //public floats for our x and y sensitivity
    [Range(0, 20)]
    public float sensitivityX = 15;
    public float sensitivityY = 15;
    //[Header("Y Rotation Clamp")]
    [Header("Y Rotation Clamp")]
    // [Header("Rotation Clamp")]
    [Header("Rotation Clamp")]
    //max and min Y rotation
    public float minY = -60;
    public float maxY = 60;
    //we will have to invert our mouse position later to calculate our mouse look correctly
    //float for rotation Y
    float rotationY = 0;
    public Joystick joystick;

    public CharacterController characterController;
    public Vector3 moveDirection;
    // public Joystick movementInput;
    //public Joystick rotInput;
    public float moveSpeed;
    public Joystick movejoystick;


    public void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    #endregion
    #region Update
    private void Update()
    {
        var horizontal = joystick.Horizontal;
        var vertical = joystick.Vertical;
        #region Mouse X and Y
        //if our axis is set to Mouse X and Y
        if (axis == RotationalAxis.JoyXandY)
        {

            float rotationX = transform.localEulerAngles.y + horizontal * sensitivityX;

            rotationY += vertical * sensitivityY;

            rotationY = Mathf.Clamp(rotationY, minY, maxY);

            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }

        #endregion
        #region Mouse X
        else if (axis == RotationalAxis.JoyX)

        {

            transform.Rotate(0, horizontal * sensitivityX, 0);
        }
        #endregion
        #region Mouse Y

        else
        {

            rotationY += vertical * sensitivityY;

            rotationY = Mathf.Clamp(rotationY, minY, maxY);

            transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
        }
        #endregion

    }

    #endregion
}
#region RotationalAxis

public enum RotationalAxis
{
    JoyXandY = 0,
    JoyX,
    JoyY
}
//Creating an enum out side the script and making it public means it can be asessed anywhere in any script with out reference
#endregion









