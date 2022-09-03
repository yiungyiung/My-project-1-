using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunss : MonoBehaviour
{
    [SerializeField]
    Transform firepoint;
    [SerializeField]
    Transform firepoint1;
    [SerializeField]
    GameObject Bullet;
    [SerializeField]
    float firespeed;
     [SerializeField]
     float bulletForce;
     float nextTimeOfFire= 0;
     bool canShoot=false;
    [SerializeField]
    bool tripguns;
    [SerializeField]
    float tripguntimer;
    float tripgunfloat;
    
    void Update()
    {   
      if(tripguns)
        {
        if(Input.GetButton("Fire1")) //When the mouse button is pressed 
      {
        canShoot = true;
      }
      if(Input.GetButtonUp("Fire1"))//when the mouse button is lifted
      {
      canShoot = false;
      }
        if(canShoot && Time.time>=nextTimeOfFire)
        {
        nextTimeOfFire = Time.time + firespeed;
        GameObject laserBullet;
        laserBullet= Instantiate(Bullet,firepoint.position,Quaternion.identity);
        Rigidbody body= laserBullet.GetComponent<Rigidbody>();
        body.AddForce(Vector3.forward*bulletForce,ForceMode.Impulse);
        GameObject laserBullet1;
        laserBullet1= Instantiate(Bullet,firepoint1.position,Quaternion.identity);
        Rigidbody body1= laserBullet1.GetComponent<Rigidbody>();
        body1.AddForce(Vector3.forward*bulletForce,ForceMode.Impulse);
        }
     
            if(tripgunfloat>=tripguntimer)
            {
                tripguns = false;
                tripgunfloat=0;
                
            }
            tripgunfloat+=Time.deltaTime;
        }
    
    }
    public void trigun()
    {   if(!tripguns)
    {
        tripguns=true;}

        else
        {
          tripgunfloat=0;
        }
       
    }
}
