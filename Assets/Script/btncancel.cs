using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btncancel : MonoBehaviour
{
    public btn menu;
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            menu.btnonoff();
        }
    }
}
