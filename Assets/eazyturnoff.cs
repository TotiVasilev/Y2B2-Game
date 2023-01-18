using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eazyturnoff : MonoBehaviour
{

    public GameObject Arrow;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Arrow.SetActive(false);
    }
}
