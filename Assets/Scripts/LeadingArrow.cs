using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeadingArrow : MonoBehaviour
{
    GameObject endOfArrow;
    GameObject player;
    Renderer rend;

    //public float temperature;
    public float origin;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        endOfArrow = GameObject.FindWithTag("Checkpoint");

        rend = GetComponent<Renderer>();
        rend.material = new Material(rend.material);
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, endOfArrow.transform.position);
     
        //temperature = - dist + 30;
        origin = - dist + 5 ;

        rend.material.SetFloat("_Origin", origin);
        //rend.material.SetFloat("_Temperature", temperature);
    }
}
