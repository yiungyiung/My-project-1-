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
     public bool canShoot=false;
     [SerializeField]
     AudioSource shootingsound;

     void Start()
    {
       Input.simulateMouseWithTouches = false;
    }
 
    
    void Update()
    {   
        if(Input.GetButton("Jump")||Input.GetMouseButton(0)) //When the mouse button is pressed 
      {
        shoottrue();
      }
      else if(Input.GetButtonUp("Jump")||Input.GetMouseButtonUp(0))//when the mouse button is lifted
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
