using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btncancel : MonoBehaviour
{
    public btn menu;
    public bool interactable=true;
    [SerializeField]
    AudioSource sound;
    void Update()
    {
        if(Input.GetButtonDown("Cancel") && interactable)
        {   
            sound.Play();
            menu.btnonoff();
        }
    }
}
