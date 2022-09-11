using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class starter : MonoBehaviour
{
    [SerializeField]
    float timer;
    [SerializeField]
    GameObject gaman;
    [SerializeField]
    Health playerhealth;
    bool started;
    [SerializeField]
    TMP_Text starthText;
void Start()
{
    timer=4;
    started = false;
}
    void Update()
    {   
        if(!started)
        
        timer=timer-=Time.deltaTime;
        starthText.SetText(""+(int)timer);
        if((int)timer==0)
        { 
            starthText.SetText("START!");
        }
        if(timer<0){
            
            gaman.SetActive(true);
            playerhealth.enabled=true;
            started=true;
            starthText.SetText("");

        }
    }
}
