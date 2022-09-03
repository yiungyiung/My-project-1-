using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x2mover : MonoBehaviour
{
    // Start is called before the first frame update

    GameManager gaman;
    
    void Start()
    {
        gaman= GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        
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
            gaman.x2();
            Destroy(gameObject);
        }

}
}
