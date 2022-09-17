using UnityEngine;
using System.Collections;


public class MessageListener : MonoBehaviour
{   
    public string[] data;
    public playermovement pla;
    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {   
        Debug.Log(msg);
        string[] data =msg.Split(',');
        pla.horimove=-(float.Parse(data[0])/10*1.2f);
        pla.vertimove=(float.Parse(data[1])/10*1.8f);

    }

    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }
}