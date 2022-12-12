using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    float currentTime;
    public float startingTime = 10f;

    [SerializeField] Text countdownText;

    void Start()
    {

        currentTime = startingTime;

    }

    void update()
    {

        currentTime += 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime >= 0)
        {

            currentTime = 120f;

            

        }

    }

}
