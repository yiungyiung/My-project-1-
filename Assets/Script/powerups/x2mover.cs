using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x2mover : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float movespeed;
    GameManager gaman;
    
    void Start()
    {
        gaman= GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        
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
            gaman.x2();
            Destroy(gameObject);
        }

}
}
