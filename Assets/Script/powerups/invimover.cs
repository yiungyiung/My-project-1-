using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invimover : MonoBehaviour
{

    [SerializeField]
    Health heal;
    [SerializeField]
    GameObject prefab;
    emotispawner emotis;
    
    void Start()
    {
        heal=GameObject.FindWithTag("Player").GetComponent<Health>();
        emotis=GameObject.FindWithTag("Player").GetComponent<emotispawner>();
        
    }
    void Update()
    {
       
        if(transform.position.z<=-10)
        {
            Destroy(gameObject);
           
        }
    }

    void OnTriggerEnter(Collider other)
    {    
        
       if(other.tag=="Player")
        {   
            emotis.spawner(prefab);
            heal.startinvi();
            Destroy(gameObject);
        }

}
}
