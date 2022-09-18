using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
   [SerializeField]
    TMP_Text Text;
    [SerializeField]
    Slider sliderr;
    [SerializeField]
    playermovement pla;
    [SerializeField]
    char sens;

    
    void Start()
    {   
        if(sens=='x')
        {
        sliderr.value=pla.speedx;}

        else if(sens=='y')
        {
             sliderr.value=pla.speedy;
        }
    }
    void Update()
    {   
         if(sens=='x')
        {
        Text.SetText("Sensitivity "+sens+": "+System.Math.Round(pla.speedx,2));}

        else if(sens=='y')
        {
              Text.SetText("Sensitivity "+sens+": "+System.Math.Round(pla.speedy,2));
        }
       
    }
}
