using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tripleguns : MonoBehaviour
{
    [SerializeField]
    float movespeed;
    [SerializeField]
    gunss gun;
    
    void Start()
    {
        gun=GameObject.FindWithTag("Player").GetComponent<gunss>();
        
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x,transform.position.y,-25),movespeed/100);
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