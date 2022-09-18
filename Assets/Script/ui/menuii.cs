using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuii : MonoBehaviour
{   [SerializeField]
    GameObject cont;
    [SerializeField]
    AudioSource sound;
    
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {   
            btnoff();
        }
    }
    public void btnoff(){
        sound.Play();
        cont.SetActive(!cont.activeSelf);
    }

   
}
