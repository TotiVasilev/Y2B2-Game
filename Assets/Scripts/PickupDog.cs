using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDog : MonoBehaviour
{
    public GameObject DOG;
    public GameObject pressUI;
    bool canBeOpened;
    public GameObject DEBRIS;
    public GameObject window;
    public GameObject safetyairbag;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canBeOpened == true)
        {
            DOG.SetActive(false);
            DEBRIS.SetActive(true);
            window.SetActive(false);
            pressUI.SetActive(false);
            safetyairbag.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
       if (other.gameObject.CompareTag("Player"))
        {
            pressUI.SetActive(true);
            canBeOpened = true;
        }   
    }

    private void OnTriggerExit(Collider other)
    {
        pressUI.SetActive(false);
        canBeOpened = false;
    }     
}
