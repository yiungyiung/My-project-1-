using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Update()
    {
        transform.position=new Vector3(transform.position.x,transform.position.y,0);

        if(transform.position.x>26)
        {
            transform.position=new Vector3(26,transform.position.y,transform.position.z);
        }

        else if(transform.position.x<-26)
        {
            transform.position=new Vector3(-26,transform.position.y,transform.position.z);
        }

        if(transform.position.y>14)
        {
            transform.position=new Vector3(transform.position.x,14,transform.position.z);
        }

        else if(transform.position.y<-14)
        {
            transform.position=new Vector3(transform.position.x,-14,transform.position.z);
        }
    }
}
