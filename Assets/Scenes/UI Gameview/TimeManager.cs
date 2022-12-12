using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public static Action OnMinuteChanged;
    public static Action OnHourChanged;

    public static int Minute { get; private set; }

    public static int Hour { get; private set; }

    private float minuteToRealTime = 3.0F;
    private float timer;



    void Start()
    {

        Minute = 0;
        Hour = 18;
        timer = minuteToRealTime;



    }

    void Update()
    {


        timer -= Time.deltaTime;

        if(timer <= 0)
        {

            Minute++;
            OnMinuteChanged?.Invoke();

            if(Minute >= 60)
            {

                Hour++;
                Minute = 0;
                OnHourChanged?.Invoke();


            }

            timer = minuteToRealTime;

        }

    }

}
