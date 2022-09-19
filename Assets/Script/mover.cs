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
    int x,y,z;
   
    float speed=25;
   
    


    void Start()
    { 
      heali=GameObject.FindWithTag("Player").GetComponent<Health>();
       movespeed =((float)(GameObject.FindWithTag("GameController").GetComponent<GameManager>().timer)/600)+assignedspeed;
       orimovespeed =movespeed;
       x=Random.Range(0,2);
       y=Random.Range(0,2);
       z=Random.Range(0,2);
       if(x==0&&y==0&&z==0)
       {
         y=1;
       }
    }
    
    void Update()
    {  
      if(obs)
      transform.Rotate(new Vector3(x,y,z)*Time.deltaTime*speed);
    
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
