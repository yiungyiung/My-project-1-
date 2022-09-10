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
    
    void Start()
    {
        gaman= GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        emotis=GameObject.FindWithTag("Player").GetComponent<emotispawner>();
    }
    void Update()
    {
        
        if(transform.position.z<=-10)
        {
            Destroy(gameObject);
           
        }
    }

    void OnTriggerEnter(Collider other)
    {    
        
       if(other.tag=="Player")
        {   
            gaman.x2();
            emotis.spawner(prefab);
            Destroy(gameObject);
        }

}
}
