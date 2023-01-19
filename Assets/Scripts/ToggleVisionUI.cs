using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisionUI : MonoBehaviour
{
    public GameObject Togglevisiontext;
    bool canBeOpened;
    public GameObject Vcollider;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canBeOpened == true)
        {
            Togglevisiontext.SetActive(true);
        }
    }
    

    private void OnTriggerStay(Collider other)
    {
       if (other.gameObject.CompareTag("Player"))
        {
            Togglevisiontext.SetActive(true);
            canBeOpened = true;
        }   
    }

    private void OnTriggerExit(Collider other) 
    {
        Togglevisiontext.SetActive(false);
        canBeOpened = false;
        Destroy(Vcollider);
    }     
}
