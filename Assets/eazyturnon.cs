using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eazyturnon : MonoBehaviour
{

    public GameObject Arrow;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Arrow.SetActive(true);
    }
}
