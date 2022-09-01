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


    void Start(){
        gaman= GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }
    

    void Update()
    {
        healthText.SetText("Health: " + health);
    }

    public void dechealth(int sub)
    {   
        health=health-sub;
        if (health <=0)
        { health=0; 
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
