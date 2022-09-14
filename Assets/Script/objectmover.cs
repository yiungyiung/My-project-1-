using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectmover : MonoBehaviour
{   
 
    [SerializeField]
    Health heal;
    GameManager gaman;
    [SerializeField]
    GameObject explosion;
  
    AudioSource sound;
    
    void Start()
    {   
        sound= GameObject.FindWithTag("sound").GetComponent<AudioSource>();
        heal=GameObject.FindWithTag("Player").GetComponent<Health>();
        gaman= GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }
    void Update()
    {
        
        if(transform.position.z<=-20)
        {
            Destroy(gameObject);
            heal.dechealth(5);
        }
    }

    void OnTriggerEnter(Collider other)
    {    
        if(other.tag=="wall")
        {   
            heal.dechealth(5);
            Destroy(gameObject);
        }
        else if(other.tag=="Player")
        {   sound.Play();
            gaman.upscore(10);
            heal.dechealth(10);
            
            Instantiate(explosion,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
        else if(other.tag=="bullet")
        {
        sound.Play();
        gaman.upscore(10);
        
        Instantiate(explosion,transform.position,Quaternion.identity);
        Destroy(other.gameObject);
        Destroy(gameObject);
        }
        else{
            Debug.Log("dumbyash");
            Debug.Log(other.tag);
    }
}
}
