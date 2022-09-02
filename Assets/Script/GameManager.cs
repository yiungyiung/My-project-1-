using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    [SerializeField]
    GameObject prefab ;
    float nextTimeOfspawn= 0;
    float randomposx;
    float randomposy;
    [SerializeField]
    float spawnspeed;
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

    void Start()
    {   
        
        kills=0;
        timer=0;
    }
    void Update()
    {
        randomposx=Random.Range(-21,21);
        randomposy=Random.Range(-11,11);

        if(Time.time>=nextTimeOfspawn)
        {
            nextTimeOfspawn = Time.time + spawnspeed;
            GameObject spawned = Instantiate(prefab,new Vector3(randomposx,randomposy,100),Quaternion.identity);
            randomsize=Random.Range(3,10);
            spawned.transform.localScale=new Vector3(randomsize,randomsize,randomsize);

        }
        timer=timer+Time.deltaTime;
        timeText.SetText(""+System.Math.Round(timer,1));
        scoreText.SetText("Score: "+ (score+(int)timer));

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
            score=score+(2*sc);
        }
    }

    public void restart(){
        SceneManager.LoadScene("main");
    }

    public void x2()
    {
        x2multipler=true;
    }
}
