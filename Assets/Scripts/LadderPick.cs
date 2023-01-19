using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LadderPick : MonoBehaviour
{
    public GameObject ladderToPutCollider;
    public GameObject ladderToHold;
    public GameObject pickUItext;
    bool canPressR;
    void Start()
    {
        canPressR = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && canPressR == true)
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
            canPressR = true;
            
        }
    }

    void OnTriggerExit()
    {
        canPressR = false;
        pickUItext.SetActive(false);
    }
}
