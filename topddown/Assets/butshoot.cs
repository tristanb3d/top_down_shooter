﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//this script can be found in the Component section under the option Intro RPG/Player/Interact
//[AddComponentMenu("Intro /PRG/RPG/Player/Interact11")]
public class butshoot : MonoBehaviour
{
    //#region Variables
    //We are setting up these variable and the tags in update for week 3,4 and 5
    //[Header("Player and Camera connection")]
    //create two gameobject variables one called player and the other mainCam
    public GameObject player;
    public GameObject Cam;
    public Transform bullets;
    public Transform projectile;
    public float fireforce;
    public Rigidbody prigd;
    // public Transform bullet;

    // #endregion
    // #region Start
    //connect our player to the player variable via tag
    //connect our Camera to the mainCam variable via tag
    //#endregion
    //#region Update
   public void shooty()
    {
        //if our interact key is pressed
     //   if (Input.GetButtonDown("Fire1"))
       // {
            //create a ray
            //Ray Interact;

            //this ray is shooting out from the main cameras screen point center of screen
            //Interact = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            //create hit info
            //RaycastHit hitInfo;

            //  Instantiate (projectile, Cam.transform.position, Cam.transform.forward);
            // Destroy(projectile); 
            bullets = Instantiate(projectile, transform.position, transform.rotation);
            bullets.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            //var bulletclone = bullets; 
            Destroy((bullets as Transform).gameObject, 3f);

            // Add force to the cloned object in the object's forward direction
            //bullet.rigidbody.AddForce(bullet.transform.forward * fireforce);
            // Set the missiles timeout destructor to 5
            // clone.timeoutDestructor = 5;

            //if this physics raycast hits something within 10 units
            //  if (Physics.Raycast(Interact, out hitInfo, 10))
            // {


            // #region NPC tag
            //and that hits info is tagged NPC
            //if (hitInfo.collider.CompareTag("NPC"))
            //{
            //Debug that we hit a NPC
            //   Debug.Log("NPC");
            //}

            //#endregion
            //#region Item
            //and that hits info is tagged Item
            //  if (hitInfo.collider.CompareTag("Item"))
            // {

            //Debug that we hit an Item
            //    Debug.Log("item");
            // }





            //  #endregion
      //  }
    }
}


//  #endregion







