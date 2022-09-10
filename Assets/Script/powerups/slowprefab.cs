using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowprefab : MonoBehaviour
{
    slowall slowed;
    [SerializeField]
    GameObject prefab;
    emotispawner emotis;
    void Start()
    {
        slowed= GameObject.FindWithTag("GameController").GetComponent<slowall>();
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
           slowed.slowstart();
           emotis.spawner(prefab);
           Destroy(gameObject);
        }

}
}