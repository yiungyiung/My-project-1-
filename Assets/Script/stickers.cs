using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickers : MonoBehaviour
{
    

     float timer;
    void Start()
    {
        timer=0;
    }

    void Update()
    {
         timer += Time.deltaTime;
    if (timer >=3f)
        {
            Destroy(gameObject);
        }   
        transform.localScale=Vector3.Lerp(transform.localScale,new Vector3(0.3f,0.3f,0.3f),0.1f);
    }
}
