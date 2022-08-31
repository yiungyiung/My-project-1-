using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    
    void Start()
    {
            Destroy(gameObject,5);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="wall")
        {
            Destroy(gameObject);
        }
        
    }
}
