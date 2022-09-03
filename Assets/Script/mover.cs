using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{   
    [SerializeField]
   public float movespeed;
    
    void Update()
    {
       transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x,transform.position.y,-25),movespeed/100);
    }
}
