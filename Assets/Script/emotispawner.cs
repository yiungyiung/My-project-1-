using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emotispawner : MonoBehaviour
{   
    public GameObject sp;
    public void spawner(GameObject prefab)
    {   
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("stickers"))
        {
            Destroy(obj);
        }
        GameObject spawned = Instantiate(prefab,sp.transform.position,Quaternion.identity);
        spawned.transform.SetParent(gameObject.transform);
    }
}
