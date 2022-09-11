using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn : MonoBehaviour
{
    
   public void btnonoff()
   {
    gameObject.SetActive(!gameObject.activeSelf);
   }
}
