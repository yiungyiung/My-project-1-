using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickui : MonoBehaviour
{

    [SerializeField]
    GameObject pre1;
    [SerializeField]
    GameObject pre2;

    void Start()
    {
        if(PlayerPrefs.GetInt("joystick")==0)
        {
            pre1.SetActive(true);
            pre2.SetActive(false);
        }
        else if(PlayerPrefs.GetInt("joystick")==1)
        {
            pre2.SetActive(true);
            pre1.SetActive(false);
        }
    }
}
