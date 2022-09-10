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


    void Start()
    {
       movespeed =((float)(GameObject.FindWithTag("GameController").GetComponent<GameManager>().timer)/600)+assignedspeed;
       orimovespeed =movespeed;
    }
    
    void Update()
    {   
       transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x,transform.position.y,-25),movespeed/100);
    }
}
