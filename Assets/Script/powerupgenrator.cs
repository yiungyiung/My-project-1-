using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupgenrator : MonoBehaviour
{   
    [SerializeField]
    GameObject[] prefab;
    [SerializeField]
    float nextTimeOfspawn;
    float randomposx;
    float randomposy;
    [SerializeField]
    float spawnspeed;
    float randomsize;
    int randobj;
    
    

    // Update is called once per frame
    
       void Update()
    {
        randomposx=Random.Range(-21,21);
        randomposy=Random.Range(-11,11);

        if(Time.time>=nextTimeOfspawn)
        {
            nextTimeOfspawn = Time.time + spawnspeed;
            GameObject spawned = Instantiate(prefab[Random.Range(0,4)],new Vector3(randomposx,randomposy,100),Quaternion.identity);
            randomsize=Random.Range(5,8);
            spawned.transform.localScale=new Vector3(randomsize,randomsize,randomsize);

        } 
    }
}

