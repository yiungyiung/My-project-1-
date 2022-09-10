using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthmover : MonoBehaviour
{
    // Start is called before the first frame update

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
            heal.Uphealth(20);
            emotis.spawner(prefab);
            Destroy(gameObject);
        }

}
}
