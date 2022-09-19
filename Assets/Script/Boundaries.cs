using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    Vector3 tmpPos;
   
    void Update()
    {
        /*transform.position=new Vector3(transform.position.x,transform.position.y,0);

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
        }*/
        tmpPos = transform.position;
        tmpPos.x = Mathf.Clamp(tmpPos.x, -26.0f, 26.0f);
        tmpPos.y = Mathf.Clamp(tmpPos.y, -14.0f, 14.0f);
        tmpPos.z=0f;
        transform.position = tmpPos;
    }
}
