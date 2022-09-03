using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthmover : MonoBehaviour
{
    // Start is called before the first frame update

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
            heal.Uphealth(20);
            Destroy(gameObject);
        }

}
}
