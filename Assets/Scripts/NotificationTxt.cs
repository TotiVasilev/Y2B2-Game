using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NotificationTxt : MonoBehaviour
{


    public string PopUP;

    void start()
    {



    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.V) == true)
        {

            PopUpSystem pop = GameObject.FindGameObjectWithTag("Script Manager").GetComponent<PopUpSystem>();
            pop.PopUp(PopUP);


        }



    }


   



}

    

