using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthmover : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Health heal;
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    GameObject particle;
    emotispawner emotis;
     AudioSource sound;
    
    void Start()
    {   
        sound= GameObject.FindWithTag("sound1").GetComponent<AudioSource>();
        heal=GameObject.FindWithTag("Player").GetComponent<Health>();
        emotis=GameObject.FindWithTag("Player").GetComponent<emotispawner>();
        
    }
   

    void OnTriggerEnter(Collider other)
    {    
        
       if(other.tag=="Player")
        {   
            sound.Play();
            heal.Uphealth(20);
            Instantiate(particle,transform.position,Quaternion.identity);
            emotis.spawner(prefab);
            Destroy(gameObject);
        }

}
}
