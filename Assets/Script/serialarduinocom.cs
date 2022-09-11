using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;

public class serialarduinocom : MonoBehaviour
{
    SerialPort serial =new SerialPort("COM6",115200);
    public string[] data;

    public string recstring;
    public playermovement pla;

    void Start()
    { 
        serial.Open();
    }
    // Update is called once per frame
    void FixedUpdate()
    {   

        recstring=serial.ReadLine();
        string[] data =recstring.Split(',');
        if(float.Parse(data[0])>3)
        {   

            pla.horimove=1;
        }
        else if(float.Parse(data[0])<-5)
        {
            pla.horimove=-1;
        }
        else
        {
            pla.horimove=0;
        }

        if(float.Parse(data[1])>8.5)
        {   

            pla.vertimove=-1;
        }
        else if(float.Parse(data[1])<6.5)
        {
            pla.vertimove=1;
        }
        else
        {
            pla.vertimove=0;
        }


    }
}
