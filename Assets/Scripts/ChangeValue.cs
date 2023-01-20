using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ChangeValue : MonoBehaviour
{

    public Text indicator;

    public bool useFixedUpdate;

    public float variableToChange;

    public float changePerSecond;

        

        void update()
    {

        if (!useFixedUpdate)
        {

            variableToChange += changePerSecond * Time.deltaTime;
                
        }

        indicator.text = (variableToChange).ToString();
    }
   
   

    void FixedUpdate()
    {


        if (useFixedUpdate)
        {
            variableToChange += changePerSecond * Time.deltaTime;
                

        }


    }



}
    

        


