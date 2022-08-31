using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

    // Update is called once per frame
    void Update()
    {
        randomposx=Random.Range(-25,25);
        randomposy=Random.Range(-13,13);

        if(Time.time>=nextTimeOfspawn)
        {
            nextTimeOfspawn = Time.time + spawnspeed;
            GameObject spawned = Instantiate(prefab,new Vector3(randomposx,randomposy,50),Quaternion.identity);
            randomsize=Random.Range(1,10);
            spawned.transform.localScale=new Vector3(randomsize,randomsize,randomsize);

        }
        timer=System.Math.Round(Time.time,1);
        timeText.SetText(""+timer);
        scoreText.SetText("Score: "+ (score+(int)Time.time));

    }

    public void upscore(int sc){
        score=score+sc;
    }
}
