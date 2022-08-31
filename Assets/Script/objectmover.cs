using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectmover : MonoBehaviour
{   
    [SerializeField]
    float movespeed;
    [SerializeField]
    Health heal;

    void Start()
    {
        heal=GameObject.FindWithTag("Player").GetComponent<Health>();
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x,transform.position.y,-25),movespeed/100);
    }

    void OnTriggerEnter(Collider other)
    {    
        if(other.tag=="wall")
        {   
            heal.dechealth(5);
            Destroy(gameObject);
        }
        else if(other.tag=="Player")
        {   
            heal.dechealth(10);
            Destroy(gameObject);
        }
        else if(other.tag=="bullet")
        {
        Destroy(gameObject);
        }
        else{
            Debug.Log("dumbyash");
    }
}
}
