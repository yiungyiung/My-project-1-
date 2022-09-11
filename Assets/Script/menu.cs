using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void strbtn()
    {
        SceneManager.LoadScene("main");
    }

    public void quitin(){
         Application.Quit();
    }
}
