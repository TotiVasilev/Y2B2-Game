using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickupDog : MonoBehaviour
{
    public GameObject DogPicked;
    public GameObject DOG;
    public GameObject pressUI;
    bool canBeOpened;
    public GameObject DEBRIS;
    public GameObject window;
    public GameObject safetyairbag;

    public GameObject axe;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canBeOpened == true)
        {
            DOG.SetActive(false);
            DEBRIS.SetActive(true);
            window.SetActive(false);
            pressUI.SetActive(false);
            safetyairbag.SetActive(true);
            DogPicked.SetActive(true);
        }

        if(Input.GetMouseButton(0) && canBeOpened == true)
        {
            axe.SetActive(true);
            StartCoroutine(SceneChange());
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

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneName: "DeathMenu");
    }
}
