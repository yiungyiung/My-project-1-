using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x2mover : MonoBehaviour
{
    // Start is called before the first frame update

    GameManager gaman;
    [SerializeField]
    GameObject prefab;
    emotispawner emotis;
    [SerializeField]
    GameObject particle;
     AudioSource sound;
    
    void Start()
    {   
        sound= GameObject.FindWithTag("sound1").GetComponent<AudioSource>();
        gaman= GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        emotis=GameObject.FindWithTag("Player").GetComponent<emotispawner>();
    }
   

    void OnTriggerEnter(Collider other)
    {    
        
       if(other.tag=="Player")
        {   
            sound.Play();
            gaman.x2();
            emotis.spawner(prefab);
            Instantiate(particle,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }

}
}
