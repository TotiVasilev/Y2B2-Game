using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LadderPick : MonoBehaviour
{
    public GameObject ladderToPutCollider;
    public GameObject ladderToHold;
    public GameObject pickUItext;
    bool canPressE;
    void Start()
    {
        canPressE = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && canPressE == true)
        {
            pickUItext.SetActive(false);
            Destroy(gameObject);
            ladderToHold.SetActive(true);
            ladderToPutCollider.SetActive(true);
        }
    }
    void OnTriggerStay(Collider other)
    {
        pickUItext.SetActive(true);

        if ((other.gameObject.tag == "Player"))
        {
            canPressE = true;
            
        }
    }

    void OnTriggerExit()
    {
        canPressE = false;
        pickUItext.SetActive(false);
    }
}
