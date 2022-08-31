using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Update()
    {
        transform.position=new Vector3(transform.position.x,transform.position.y,0);

        if(transform.position.x>25)
        {
            transform.position=new Vector3(25,transform.position.y,transform.position.z);
        }

        else if(transform.position.x<-25)
        {
            transform.position=new Vector3(-25,transform.position.y,transform.position.z);
        }

        if(transform.position.y>13)
        {
            transform.position=new Vector3(transform.position.x,13,transform.position.z);
        }

        else if(transform.position.y<-13)
        {
            transform.position=new Vector3(transform.position.x,-13,transform.position.z);
        }
    }
}
