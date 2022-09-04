using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowall : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    bool slowalll;
    [SerializeField]
    float slowalltimer;
    float slowallfloat;

    // Update is called once per frame
    void Update()
    {
        if(slowalll){
            if(slowallfloat>=slowalltimer)
            {
                slowalll = false;
                slowallfloat=0;
                slowerup();
            }
            else
            {
                
            
           slower();
           slowallfloat+=Time.deltaTime;}}
    }

    public void slowstart()
    {   if(!slowalll)
    { slowalll = true;}
    else{slowallfloat=0;}
        
    }
    void slower()
    {
    foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Enemy")){
            obj.GetComponent<mover>().movespeed=0.3f;
        }
    }
    void slowerup()
    {
    foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Enemy")){
            obj.GetComponent<mover>().movespeed= obj.GetComponent<mover>().orimovespeed;
        }
    }
}
