using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{   
    void Awake() {
    
     QualitySettings.vSyncCount = 0;
     Application.targetFrameRate = 60;
     
 }
    public void strbtn()
    {
        SceneManager.LoadScene("main");
    }

    public void quitin(){
         Application.Quit();
    }
}
