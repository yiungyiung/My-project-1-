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
    

    void Update()
    {
        healthText.SetText("Health: " + health);
    }

    public void dechealth(int sub)
    {   
        health=health-sub;
        if (health <=0)
        { health=0; 
          Debug.Log("highscore"+GameObject.FindWithTag("GameController").GetComponent<GameManager>().timer);
        }
    }
    

}
