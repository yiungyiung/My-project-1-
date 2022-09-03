using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tripleguns : MonoBehaviour
{

    [SerializeField]
    gunss gun;
    
    void Start()
    {
        gun=GameObject.FindWithTag("Player").GetComponent<gunss>();
        
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
            gun.trigun();
            Destroy(gameObject);
        }

}
}