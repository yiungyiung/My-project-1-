/**
 * Ardity (Serial Communication for Arduino + Unity)
 * Author: Daniel Wilches <dwilches@gmail.com>
 *
 * This work is released under the Creative Commons Attributions license.
 * https://creativecommons.org/licenses/by/2.0/
 */

using UnityEngine;
using System.Collections;

/**
 * When creating your message listeners you need to implement these two methods:
 *  - OnMessageArrived
 *  - OnConnectionEvent
 */
public class SampleMessageListener : MonoBehaviour
{   
    public string[] data;
    public playermovement pla;
    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {
        string[] data =msg.Split(',');
        if(float.Parse(data[0])>3)
        {   

            pla.horimove=-1;
        }
        else if(float.Parse(data[0])<-5)
        {
            pla.horimove=1;
        }
        else
        {
            pla.horimove=0;
        }

        if(float.Parse(data[1])>9)
        {   

            pla.vertimove=1;
        }
        else if(float.Parse(data[1])<6)
        {
            pla.vertimove=-1;
        }
        else
        {
            pla.vertimove=0;
        }

    }

    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }
}
