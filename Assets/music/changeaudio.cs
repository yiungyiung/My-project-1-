using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeaudio : MonoBehaviour
{
    [SerializeField] AudioSource ac;
    void Start()
    {
        ac.volume=0.03f*PlayerPrefs.GetFloat("volume");
    }

}
