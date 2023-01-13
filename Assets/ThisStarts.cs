using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class ThisStarts : MonoBehaviour
{
    public GameObject Door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        StartCoroutine(Door.GetComponent<S_StartDoorGlow>().EmissionUp());
    }
}
