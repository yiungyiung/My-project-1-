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

    void Start()
    {
        kills=0;
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
        timer=System.Math.Round(Time.time,1);
        timeText.SetText(""+timer);
        scoreText.SetText("Score: "+ (score+(int)Time.time));

    }

    public void upscore(int sc){
        kills+=1;
        score=score+sc;
    }

    public void restart(){
        SceneManager.LoadScene("main");
    }
}
