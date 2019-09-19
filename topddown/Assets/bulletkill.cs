using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmai : MonoBehaviour
{
    public GameObject Enm;
    public GameObject Player;
    //move to position 
    public Vector3 vec3;
    public float movespeed = 5f;

    private void Start()
    {
        //  vec3 = transform.position - Enm.transform.position;
    }

    void Update()
    {
        transform.LookAt(Player.transform);
        transform.position += transform.forward * movespeed * Time.deltaTime;

    }



    //do  damage 
    //colider 
    //
    //Destroy(col.gameObject);

    void OnTriggerEnter(Collider coli)
    {
        //do dammage 
        if (coli.gameObject.CompareTag("Player"))
        {
            //Destroy(Player);
            Debug.Log("hito");

        }
        if (coli.gameObject.CompareTag("bullet"))
        {
            Destroy(Enm);
            Debug.Log("bulleto");

        }
    }

}
