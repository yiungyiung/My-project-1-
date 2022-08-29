using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    float time=0;
    
    void Update()
    {
        time=time+Time.deltaTime;

        if (time>=10)
        {
            Destroy(gameObject);
        }

    }
}
