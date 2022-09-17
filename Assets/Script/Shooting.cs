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
     [SerializeField]
     AudioSource shootingsound;
    
    void Update()
    {   
        if(Input.GetButton("Fire1")) //When the mouse button is pressed 
      {
        shoottrue();
      }
      if(Input.GetButtonUp("Fire1"))//when the mouse button is lifted
      {
      shootfalse();
      }
        if(canShoot && Time.time>=nextTimeOfFire)
        {
        shootingsound.Stop();
        nextTimeOfFire = Time.time + firespeed;
        GameObject laserBullet;
        laserBullet= Instantiate(Bullet,firepoint.position,Quaternion.identity);
        shootingsound.Play();
        Rigidbody body= laserBullet.GetComponent<Rigidbody>();
        body.AddForce(Vector3.forward*bulletForce,ForceMode.Impulse);}
    }

    public void shoottrue(){
      canShoot = true;
    }
    public void shootfalse(){
      canShoot = false;
    }


    
        
    
}
