using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camscrr : MonoBehaviour
{
    void Awake() {
    
     QualitySettings.vSyncCount = 0;
     Application.targetFrameRate = 60;
     
 }
}
