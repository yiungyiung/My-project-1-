using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{   
    [SerializeField]
    Rigidbody rb;
    float horimove;
    float vertimove;
    Vector3 movedirec;
    [SerializeField]
    float speed;
    
    void Awake() {
     QualitySettings.vSyncCount = 0;
     Application.targetFrameRate = 500;
 }
  
    void FixedUpdate()
    {
        
        horimove=Input.GetAxisRaw("Horizontal");
        vertimove=Input.GetAxisRaw("Vertical");
         if(horimove==-1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.rotation.x,transform.rotation.y,30),0.1f);
        }
        else if(horimove==1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.rotation.x,transform.rotation.y,-30),0.1f);
        }
        else if(transform.rotation.z!=0 && horimove==0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(transform.rotation.x,transform.rotation.y,0),0.1f);
        }
        movedirec = Vector3.up*vertimove + Vector3.right * horimove;
        rb.AddForce(movedirec*speed,ForceMode.Force);
    }
}
