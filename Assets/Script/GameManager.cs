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
   public TMP_Text scoreText;
    public int score;
    public int kills;
    [SerializeField]
    bool x2multipler;
    [SerializeField]
    float x2timer;
    float x2timerfloat;
    float timerupper;
    [SerializeField]
    GameObject prefabkiller;
    emotispawner emotis;
    [SerializeField]
    GameObject[] prefabplanet;

    void Start()
    {   
        emotis=GameObject.FindWithTag("Player").GetComponent<emotispawner>();
        timerupper =20;
        kills=0;
        timer=0;
        spawnspeed=assspeed;
    }
    void Update()
    {
        randomposx=Random.Range(-21,22);
        randomposy=Random.Range(-11,12);

        
        timer=timer+Time.deltaTime;
        timeText.SetText(""+(float)System.Math.Round(timer,1));
        scoreText.SetText(""+ (score+(int)timer));
        if(timer>=nextTimeOfspawn)
        {
            nextTimeOfspawn = (float)timer + spawnspeed;
            
            GameObject spawned = Instantiate(prefabplanet[Random.Range(0,prefabplanet.Length)],new Vector3(randomposx,randomposy,175),Quaternion.identity);
            randomsize=Random.Range(1.5f,5f);
            spawned.transform.localScale=new Vector3(randomsize,randomsize,randomsize);


        }

        if(timer>timerupper && spawnspeed>0.6)
        {
            spawnspeed=spawnspeed-0.1f;
            timerupper=timerupper+20;

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
         emotis.spawner(prefabkiller);
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

    public void menu(){
        SceneManager.LoadScene("menu");
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
