using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmspawn3 : MonoBehaviour
{

    public GameObject Spawner;
    public Transform t;
    public float SpawnTimer2 ;
    public float SpawnWait;



    public void FixedUpdate()
    {
        SpawnTimer2 = SpawnTimer2  + 2f;
        SpawnWait = SpawnWait + 2f;
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
