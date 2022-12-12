using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakdoor : MonoBehaviour
{
    public GameObject door;
    public GameObject pressUI;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
       if (other.gameObject.CompareTag("Player"))
        {
            pressUI.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            pressUI.SetActive(false);
            door.SetActive(false);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        pressUI.SetActive(false);
    }
}
