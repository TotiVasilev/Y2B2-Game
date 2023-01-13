using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temperature : MonoBehaviour

{
    static float CurrentTemp = 20;
    public float RaisingTemp;
    public float MaxTemp;

    public Text text;

    private void Update()
    {
        text.text = "°C" + CurrentTemp.ToString("f1");
    }
    public void Raise()
    {
        if (CurrentTemp < MaxTemp)
            //CurrentTemp++;
        CurrentTemp = CurrentTemp + RaisingTemp * Time.deltaTime;
    }

    public void Lower()
    {
        if(CurrentTemp > MaxTemp)
        CurrentTemp = CurrentTemp - RaisingTemp * Time.deltaTime;
    }

}