using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tripleguns : MonoBehaviour
{

    [SerializeField]
    gunss gun;
    [SerializeField]
    GameObject prefab;
    emotispawner emotis;
    [SerializeField]
    GameObject particle;
     AudioSource sound;
    
    void Start()
    {   
        sound= GameObject.FindWithTag("sound1").GetComponent<AudioSource>();
        gun=GameObject.FindWithTag("Player").GetComponent<gunss>();
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
            gun.trigun();
            Destroy(gameObject);
        }

}
}