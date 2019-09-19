using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Interact1 : MonoBehaviour
{
    #region Variables

    [Header("Player and Camera connection")]

    public GameObject player;
    public GameObject Cam;
    public Transform bullets;
    public Transform projectile;
    public float fireforce;
    public Rigidbody prigd;
    public Transform bullet;

    #endregion
    #region Start

    #endregion
    #region Update
    private void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {

            Ray Interact;


            Interact = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));

            RaycastHit hitInfo;

            //  Instantiate(projectile, Cam.transform.position, Cam.transform.forward);
            Destroy(projectile);
            bullets = Instantiate(projectile, transform.position, transform.rotation);
            bullets.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            var bulletclone = bullets;
            Destroy((bullets as Transform).gameObject, 2f);


            // bullet.rigidbody.AddForce(bullet.transform.forward * fireforce);

            // clone.timeoutDestructor = 5;

            //if this physics raycast hits something within 10 units
            if (Physics.Raycast(Interact, out hitInfo, 10))
            {


                #region NPC tag
                //   and that hits info is tagged NPC
                if (hitInfo.collider.CompareTag("NPC"))
                {

                    Debug.Log("NPC");
                }

                #endregion
                #region Item

                if (hitInfo.collider.CompareTag("Item"))
                {


                    Debug.Log("item");
                }





                #endregion
            }
        }
    }
}

    #endregion







