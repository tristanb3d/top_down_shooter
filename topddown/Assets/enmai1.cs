﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class enmai1 : MonoBehaviour
{
    public GameObject Enm;
    //public GameObject Player;
    //move to position 
    public Vector3 vec3;
    public float movespeed = 5f;
    public Transform target;
    public int Scorey =  10;

    private void Start()
    {
        //  vec3 = transform.position - Enm.transform.position;
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.LookAt(target.transform);
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
            Destroy(Enm);
            SceneManager.LoadScene(0); 
            

        }
        if (coli.gameObject.CompareTag("bullet"))
        {
            Destroy(Enm);
            Debug.Log("bulleto");
            points.scorecount += Scorey; 

        }
    }

}
