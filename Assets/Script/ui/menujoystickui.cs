using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menujoystickui : MonoBehaviour
{
    int joystickchosen;
    [SerializeField]
    public Toggle Toggle1;
    [SerializeField]
    public Toggle Toggle2;
    [SerializeField]
    Image img1;
    [SerializeField]
    Image img2;
    void Start()
    {   Debug.Log(PlayerPrefs.GetInt("played"));
        Debug.Log(PlayerPrefs.GetInt("joystick"));
        if(PlayerPrefs.GetInt("played")==0){
            PlayerPrefs.SetInt("joystick",0);
        }
        if (PlayerPrefs.GetInt("played")==1)
        {
            if(PlayerPrefs.GetInt("joystick")==0)
            {   
                
                joystickchosen=1;
                joy();

            }
           else if(PlayerPrefs.GetInt("joystick")==1)
            {
                
                joystickchosen=0;
                joy();
            }
        }
    }

    public void joy(){
        if(joystickchosen==0)
        {
                Toggle1.isOn=false;
                Toggle2.isOn=true;
                var tempcol=img1.color;
                tempcol.a=150;
                img1.color=tempcol;
                joystickchosen=1;
                PlayerPrefs.SetInt("joystick",1);
        }
        else if(joystickchosen==1)
        {
                Toggle1.isOn=true;
                Toggle2.isOn=false;
                var tempcol=img2.color;
                tempcol.a=150;
                img2.color=tempcol;
                joystickchosen=0;
                PlayerPrefs.SetInt("joystick",0);
        }
    }

}
