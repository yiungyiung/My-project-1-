using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowprefab : MonoBehaviour
{
    slowall slowed;
    [SerializeField]
    GameObject prefab;
    emotispawner emotis;
    [SerializeField]
    GameObject particle;
     AudioSource sound;
    void Start()
    {   
        sound= GameObject.FindWithTag("sound1").GetComponent<AudioSource>();
        slowed= GameObject.FindWithTag("GameController").GetComponent<slowall>();
        emotis=GameObject.FindWithTag("Player").GetComponent<emotispawner>();
        
    }
   
    void OnTriggerEnter(Collider other)
    {    
        
       if(other.tag=="Player")
        {   
            sound.Play();
           slowed.slowstart();
           Instantiate(particle,transform.position,Quaternion.identity);
           emotis.spawner(prefab);
           Destroy(gameObject);
        }

}
}