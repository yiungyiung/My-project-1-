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
    
    void Start()
    {
        gun=GameObject.FindWithTag("Player").GetComponent<gunss>();
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
            gun.trigun();
            Destroy(gameObject);
        }

}
}