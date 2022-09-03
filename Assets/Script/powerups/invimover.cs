using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invimover : MonoBehaviour
{

    [SerializeField]
    Health heal;
    
    void Start()
    {
        heal=GameObject.FindWithTag("Player").GetComponent<Health>();
        
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
            heal.startinvi();
            Destroy(gameObject);
        }

}
}
