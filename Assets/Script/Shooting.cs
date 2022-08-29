using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    Transform firepoint;
    [SerializeField]
    GameObject Bullet;
    [SerializeField]
    float firespeed;
     [SerializeField]
     float bulletForce;
     float nextTimeOfFire= 0;
     bool canShoot=false;
    
    void Update()
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
        body.AddForce(Vector3.forward*bulletForce,ForceMode.Impulse);}
    }

    
        
    
}
