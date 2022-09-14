using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invimover : MonoBehaviour
{

    [SerializeField]
    Health heal;
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    GameObject particle;
    emotispawner emotis;
     AudioSource sound;
    
    void Start()
    {   
        sound= GameObject.FindWithTag("sound1").GetComponent<AudioSource>();
        heal=GameObject.FindWithTag("Player").GetComponent<Health>();
        emotis=GameObject.FindWithTag("Player").GetComponent<emotispawner>();
        
    }
    void Update()
    {
       
        if(transform.position.z<=-20)
        {
            Destroy(gameObject);
           
        }
    }

    void OnTriggerEnter(Collider other)
    {    
        
       if(other.tag=="Player")
        {   
            sound.Play();
            emotis.spawner(prefab);
            Instantiate(particle,transform.position,Quaternion.identity);
            heal.startinvi();
            Destroy(gameObject);
        }

}
}
