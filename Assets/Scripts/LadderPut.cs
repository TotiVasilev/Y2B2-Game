using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderPut : MonoBehaviour
{
    public GameObject ladderToPut;
    public GameObject ladderToHold;
    public GameObject placeUItext;
    bool canPresE;
    void Start()
    {
        canPresE = false;
    }

    void Update()
    {
        if(Input.GetKeyDown (KeyCode.E) && canPresE == true)
        {
            placeUItext.SetActive(false);
            Destroy(gameObject);
            ladderToHold.SetActive(false);
            ladderToPut.SetActive(true);
        }
    }
    void OnTriggerStay(Collider other)
    {
        placeUItext.SetActive(true);

        
        if ((other.gameObject.tag == "Player"))
        {
            canPresE = true;
        }
    }

    void OnTriggerExit()
    {
        placeUItext.SetActive(false);
        canPresE = false;
    }
}
