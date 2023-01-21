using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RadialBar : MonoBehaviour
{
    public Image fill;
    public TextMeshProUGUI amount;

    public int currentValue, maxValue;

    public int defValue = 0;





    void Start()
    {
        fill.fillAmount = Normalise();
        amount.text = $"{currentValue}/{maxValue}";

        defValue = currentValue;
    }

    public void Add(int val)
    {
        currentValue += val;

        if (currentValue > maxValue)
            currentValue = maxValue;

        fill.fillAmount = Normalise();
        amount.text = $"{currentValue}/{maxValue}";
    }


    public void Reset(int val)
    {
        if (currentValue == maxValue)
        {
            currentValue = defValue;
        }

    }

    private float Normalise()
    {
        return (float)currentValue / maxValue;
    }
}


