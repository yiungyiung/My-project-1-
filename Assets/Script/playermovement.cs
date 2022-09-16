using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{   
    [SerializeField]
    Rigidbody rb;
    public float horimove;
    public float vertimove;
    Vector3 movedirec;
    [SerializeField]
    float speed;
    
    void Awake() {
     QualitySettings.vSyncCount = 0;
     Application.targetFrameRate = 60;
 }
  
    void FixedUpdate()
    {
             
        
        
       
         if(horimove<-0.2)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.rotation.x,transform.rotation.y,30),0.1f);
        }
        else if(horimove>0.2)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.rotation.x,transform.rotation.y,-30),0.1f);
        }
        else if(transform.rotation.z!=0 && horimove==0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.rotation.x,transform.rotation.y,0),0.1f);
        }
        movedirec = Vector3.up*vertimove*speed/1.5f + Vector3.right * horimove*speed/1.2f;
        rb.AddForce(movedirec,ForceMode.Acceleration);
    }
}
