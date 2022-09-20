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
    [SerializeField]
    GameManager tme;
    
    
    void Start()
    {
        tme=gameObject.GetComponent<GameManager>();
    }
    // Update is called once per frame
    
       void Update()
    {
        randomposx=Random.Range(-21,22);
        randomposy=Random.Range(-11,12);

        if(tme.timer>=nextTimeOfspawn)
        {
            nextTimeOfspawn = (float)tme.timer + spawnspeed;
            spawnspeed =Random.Range(6,10);
            GameObject spawned = Instantiate(prefab[Random.Range(0,prefab.Length)],new Vector3(randomposx,randomposy,175),transform.rotation *  Quaternion.Euler(0, 180, 0));
            
            spawned.transform.localScale=new Vector3(4,4,4);

        } 
    }
}

