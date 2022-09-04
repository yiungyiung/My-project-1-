using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    [SerializeField]
    GameObject prefab ;
    [SerializeField]
    float nextTimeOfspawn= 0;
    float randomposx;
    float randomposy;
    [SerializeField]
    float spawnspeed;
    [SerializeField]
    float assspeed;
    float randomsize;
    [SerializeField]
    TMP_Text timeText;
    public double timer;
    [SerializeField]
    TMP_Text scoreText;
    public int score;
    public int kills;
    [SerializeField]
    bool x2multipler;
    [SerializeField]
    float x2timer;
    float x2timerfloat;
    float timerupper;

    void Start()
    {   
        timerupper =15;
        kills=0;
        timer=0;
        spawnspeed=assspeed;
    }
    void Update()
    {
        randomposx=Random.Range(-21,22);
        randomposy=Random.Range(-11,12);

        
        timer=timer+Time.deltaTime;
        timeText.SetText(""+System.Math.Round(timer,1));
        scoreText.SetText("Score: "+ (score+(int)timer));
        if(timer>=nextTimeOfspawn)
        {
            nextTimeOfspawn = (float)timer + spawnspeed;
            
            GameObject spawned = Instantiate(prefab,new Vector3(randomposx,randomposy,100),Quaternion.identity);
            randomsize=Random.Range(3,10);
            spawned.transform.localScale=new Vector3(randomsize,randomsize,randomsize);


        }

        if(timer>timerupper && spawnspeed>0.8)
        {
            spawnspeed=spawnspeed-0.2f;
            timerupper=timerupper+15;

        }

        if(x2multipler)
        {
            if(x2timerfloat>=x2timer)
            {
                x2multipler = false;
                x2timerfloat=0;
            }
            x2timerfloat+=Time.deltaTime;
        }

    }

    public void upscore(int sc){
        kills+=1;
        if(!x2multipler)
        {
        score=score+sc;}
        else
        {
            score=score+(4*sc);
        }
    }

    public void restart(){
        SceneManager.LoadScene("main");
    }

    public void x2()
    {   if(!x2multipler)
        {x2multipler=true;} 
        else
        {
            x2timerfloat=0;
        }
    }
}
