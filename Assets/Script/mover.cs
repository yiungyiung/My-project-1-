using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{   
   [SerializeField]
   public float movespeed;
   public float orimovespeed;
   [SerializeField]
   public float assignedspeed;
   [SerializeField]
   float dist;
   [SerializeField]
   bool obs;
   [SerializeField]
    Health heali;
   
    float speed=25;
   
    


    void Start()
    { 
      heali=GameObject.FindWithTag("Player").GetComponent<Health>();
       movespeed =((float)(GameObject.FindWithTag("GameController").GetComponent<GameManager>().timer)/600)+assignedspeed;
       orimovespeed =movespeed;
    }
    
    void Update()
    {  
      if(obs)
      transform.Rotate(new Vector3(0,1,0)*Time.deltaTime*speed);
    
       transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x,transform.position.y,-25),movespeed/100);
   
        if(transform.position.z<=dist)
        {   
         if(obs)
            {
               heali.dechealth(5);
            }
            Destroy(gameObject);
            
           
        }
    
    }
}
