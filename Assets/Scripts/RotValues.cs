using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RotValues : MonoBehaviour
{
    float gyrox;
    float gyroy;
    float accx;
    float accy;
    float accz;

    public Shooting shot;
    float errgx,errgy,errax,erray,erraz;

    public string[] data;
    
    // Kalman filter parameters
    KalmanFilters kalmanX;
    KalmanFilters kalmanY;
    KalmanFilters kalmanYa;
    KalmanFilters kalmanXa;
    [SerializeField]
    TMP_Text accys;

    int sample_size = 500;
    int scale = 10;

    bool cal=false;
    float alpha = 0.91f;

    [SerializeField]
    playermovement pla;
    void Start()
    {
        // Initialize Kalman filters
        kalmanX = new KalmanFilters();
        kalmanY = new KalmanFilters();
        kalmanXa=new KalmanFilters();
        kalmanYa=new KalmanFilters();
        kalmanX.SetState(gyrox);
        kalmanY.SetState(gyroy);
        errgx=PlayerPrefs.GetFloat("errgx");
        errgy=PlayerPrefs.GetFloat("errgy");
        errax=PlayerPrefs.GetFloat("errax");
        erray=PlayerPrefs.GetFloat("erray");
        while (data.Length<3)
        {

        }
        calibration();
    }

    void calibration()
    {
        // Calibration code...
        float sumgx = 0;
        float sumgy = 0;
        float sumax = 0;
        float sumay = 0;
        float sumaz = 0;
        int i = 0;
        cal=false;
        while (i < sample_size)
        {   
            gyrox = float.Parse(data[0]);
            gyroy = float.Parse(data[1]);
            accx = float.Parse(data[2]);
            accy = float.Parse(data[3]);
            sumgx += gyrox;
            sumgy += gyroy;
            sumax += accx;
            sumay += accy;
            sumaz += accz;
            i += 1;
        }
        errgx = sumgx / sample_size;
        errgy = sumgy / sample_size;
        errax = sumax / sample_size;
        erray = sumay / sample_size;
        erraz = sumaz / sample_size;
        // Initialize Kalman filter states after calibration
        PlayerPrefs.SetFloat("errgx", errgx);
        PlayerPrefs.SetFloat("errgy", errgy);
        PlayerPrefs.SetFloat("errax", errax);
        PlayerPrefs.SetFloat("erray", erray);
        Debug.Log("cali complete");
    }
    public void cancal()
    {
        cal=true;
    }
    void FixedUpdate()
    {
        if (data.Length > 3)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {   
                Debug.Log("lol");
                cancal();
            }

            if(cal)
            {
                calibration();
            }
            // Update sensor readings
            gyrox = float.Parse(data[0]) + (-1) * errgx;
            gyroy = float.Parse(data[1]) + (-1) * errgy;
            accx = float.Parse(data[2]) + (-1) * errax;
            accy = float.Parse(data[3]) + (-1) * erray;
            // Kalman filter prediction and update
            float filteredX = kalmanX.PredictAndUpdate(gyrox);
            float filteredY = kalmanY.PredictAndUpdate(gyroy);
            float acccx = kalmanY.PredictAndUpdate(accx);
            float acccy = kalmanY.PredictAndUpdate(accy);

            int angle_x = (int)((alpha * accx + (1 - alpha) * filteredX) * scale);
            int angle_y = (int)((alpha * accy + (1 - alpha) * filteredY) * scale);
            if(angle_y<-25)
            {
                pla.horimove=1;
            }
            else if(angle_y>25)
            {
                 pla.horimove=-1;
            }
            else if(angle_y<35 && angle_y>-35)
            {
                pla.horimove=0;
            }

            if(angle_x<-25)
            {
                pla.vertimove=1;
            }
            else if(angle_x>25)
            {
                 pla.vertimove=-1;
            }
            else if(angle_x<35 && angle_x>-35)
            {
                pla.vertimove=0;
            }
                    if(data[6]=="1")
        {
            shot.shootfalse();
        }
        else if(data[6]=="0")
        {
             shot.shoottrue();
        }
        }
    }
}

public class KalmanFilters
{
    private float Xk; // State estimate
    private float Pk; // Estimate error covariance

    private float Q = 0.01f; // Process noise covariance
    private float R = 0.1f;  // Measurement noise covariance

    public void SetState(float initialState)
    {
        Xk = initialState;
        Pk = 1.0f; // Initial covariance estimation
    }

    public float PredictAndUpdate(float measurement)
    {
        // Prediction
        float Xk_ = Xk;
        float Pk_ = Pk + Q;

        // Kalman gain
        float K = Pk_ / (Pk_ + R);

        // Update state
        Xk = Xk_ + K * (measurement - Xk_);
        Pk = (1 - K) * Pk_;

        return Xk;
    }
}
