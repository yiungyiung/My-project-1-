using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowprefab : MonoBehaviour
{
    slowall slowed;
    
    void Start()
    {
        slowed= GameObject.FindWithTag("GameController").GetComponent<slowall>();
        
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
           slowed.slowstart();
            Destroy(gameObject);
        }

}
}