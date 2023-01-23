using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakdoor : MonoBehaviour
{
    public GameObject door;
    public GameObject pressUI;
    bool canBeOpened;
    public GameObject arrow;
    public GameObject axe;
    void Update()
    {
        if (Input.GetMouseButton(0) && canBeOpened == true)
        {
            StartCoroutine("BreakDoor");
            arrow.SetActive(false);
            axe.SetActive(true);
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
    }

    private IEnumerator BreakDoor()
    {
        yield return new WaitForSeconds(0.7f);
        axe.SetActive(false);
        pressUI.SetActive(false);
        door.SetActive(false);
    }
        
}
