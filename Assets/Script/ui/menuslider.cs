using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class menuslider : MonoBehaviour
{
    
    public float speedy;
    public float speedx;
    [SerializeField]
    Slider sliderr;
    [SerializeField]
    Slider sliderr1;
    [SerializeField]
    TMP_Text Text;
    [SerializeField]
    TMP_Text Text1;
    void Start()
    {
    if(PlayerPrefs.GetInt("played")==0){
    speedx=10;
    speedy=10;
    PlayerPrefs.SetFloat("sensey",speedy);
    PlayerPrefs.SetFloat("sensex",speedx);
    PlayerPrefs.SetInt("played",1);
     sliderr.value=speedx;
    sliderr1.value=speedy;

    }
    else
    {
    speedx=PlayerPrefs.GetFloat("sensex");
    speedy=PlayerPrefs.GetFloat("sensey");}
    sliderr.value=speedx;
    sliderr1.value=speedy; 
    }

    
    void Update()
    {
        
        Text.SetText("Sensitivity x"+": "+System.Math.Round(speedx,2));
        Text1.SetText("Sensitivity y"+": "+System.Math.Round(speedy,2));
    }

     public void changespeedx(float x)
    {
        speedx = x;
        PlayerPrefs.SetFloat("sensex",speedx);
    }
   public  void changespeedy(float y)
    {
        speedy = y;
         PlayerPrefs.SetFloat("sensey",speedy);
    }
}
