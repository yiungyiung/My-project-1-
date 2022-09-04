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


    void Start(){
        gaman= GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }
    

    void Update()
    {
        healthText.SetText("Health: " + health);
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
        if (health <=0)
        { health=0;
          foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Enemy")){
            Destroy(obj);
        }
          healthText.SetText("Health: " + health); 
          finalscore=(int)gaman.timer + gaman.score;
          kills=gaman.kills;
          timer.SetText("Time: "+(int)gaman.timer+" sec");
          rescanvas.SetActive(true);
          killer.SetText("KILLED:" + kills);
          scorer.SetText("SCORE: " + finalscore);
          gaman.gameObject.SetActive(false);
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
