using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emotispawner : MonoBehaviour
{   
    public void spawner(GameObject prefab)
    {   
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("stickers"))
        {
            Destroy(obj);
        }
        GameObject spawned = Instantiate(prefab,new Vector3(transform.position.x,transform.position.y+1,transform.position.z-3),Quaternion.identity);
        spawned.transform.SetParent(gameObject.transform);
    }
}
