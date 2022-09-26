using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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
    [SerializeField]
    Button myButton;
    [SerializeField]
    Button myButton1;
    [SerializeField]
    btncancel btns;
    [SerializeField]
    AudioSource dam;
    [SerializeField]
    GameObject highscoreobject;


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
        dam.Stop();
        health=health-sub;
         emotis.spawner(prefab);
         dam.Play();

        if (health <=0)
        { health=0;
          foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Enemy")){
            Destroy(obj);
        }  
          healthText.SetText("" + health); 
          finalscore=(int)gaman.opscore;
          if(gaman.greaterscore)
          {
            highscoreobject.SetActive(true);
             PlayerPrefs.SetInt("high",finalscore);
          }
          gaman.scoreText.SetText("" + finalscore);
          kills=gaman.kills;
          timer.SetText("Time: "+(int)gaman.timer+" sec");
          rescanvas.SetActive(true);
          myButton.interactable = false;
          myButton1.interactable = false;
          btns.interactable = false;
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
