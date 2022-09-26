using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HIGHSCOREUI : MonoBehaviour
{
    [SerializeField]
    TMP_Text HigscoreText;
    void Start()
    {
        HigscoreText.SetText(""+PlayerPrefs.GetInt("high"));
    }

}
