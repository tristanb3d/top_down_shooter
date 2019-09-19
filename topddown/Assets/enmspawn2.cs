using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmspawn2 : MonoBehaviour
{

    public GameObject Spawner;
    public Transform t;
    public float SpawnTimer2 = 3f ;
    public float SpawnWait = 3f ;



    public void FixedUpdate()
    {
       SpawnTimer2 = SpawnTimer2  -0.05f; 
       SpawnWait = SpawnWait   -0.05f ; 
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", SpawnTimer2, SpawnWait);
    }

    // Update is called once per frame
    void Spawn()
    {
        //  bool SpawnStop;
        Instantiate(Spawner, transform.position, transform.rotation);
        // if (SpawnStop)
        //   {
        //         CancelInvoke("Spawn");
        //     }

    }




}
