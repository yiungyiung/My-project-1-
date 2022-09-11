using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    [SerializeField]
    int health ;
    [SerializeField]
    TMP_Text healthText;
    GameManager gaman;
    int finalscore;
    int kills;
    [SerializeField]
    TMP_Text killer;
    [SerializeField]
    TMP_Text scorer;
    [SerializeField]
    GameObject rescanvas;
    [SerializeField]
    TMP_Text timer;
    public bool invincibility;
    [SerializeField]
    float invitimer;
    float invitimerfloat;
    [SerializeField]
    GameObject prefab;
    emotispawner emotis;


    void Start(){
        gaman= GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        emotis=gameObject.GetComponent<emotispawner>();
    }
    

    void Update()
    {
        healthText.SetText("" + health);
         if(invincibility)
        {
            if(invitimerfloat>=invitimer)
            {
                invincibility = false;
                invitimerfloat=0;
            }
            invitimerfloat+=Time.deltaTime;
        }
    }

    public void dechealth(int sub)
    {   if(!invincibility){
        health=health-sub;
         emotis.spawner(prefab);

        if (health <=0)
        { health=0;
          foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Enemy")){
            Destroy(obj);
        }  
          healthText.SetText("" + health); 
          finalscore=(int)gaman.timer + gaman.score;
          gaman.scoreText.SetText("" + finalscore);
          kills=gaman.kills;
          timer.SetText("Time: "+(int)gaman.timer+" sec");
          rescanvas.SetActive(true);
          killer.SetText("KILLED:" + kills);
          scorer.SetText("SCORE: " + finalscore);
          gaman.enabled=false;
          GameObject.FindWithTag("GameController").GetComponent<powerupgenrator>().enabled=false;
          gameObject.SetActive(false);
        }
    }
        
    }
    public void Uphealth(int sub)
    {
        health+=sub;
    }

    public void startinvi()
    {   
        if(!invincibility)
        {invincibility=true;}
        else
        {
            invitimerfloat=0;
        }
    }
    

}
