using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btncancel : MonoBehaviour
{
    public btn menu;
    public bool interactable=true;
    void Update()
    {
        if(Input.GetButtonDown("Cancel") && interactable)
        {
            menu.btnonoff();
        }
    }
}
