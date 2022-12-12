using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakdoor : MonoBehaviour
{
    public GameObject door;
    public GameObject pressUI;
    bool canBeOpened;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V) && canBeOpened == true)
        {
            pressUI.SetActive(false);
            door.SetActive(false);

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
}
