using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThermalStrength : MonoBehaviour
{
    GameObject player;
    Renderer rend;

    public float temperature;
    public float alpha;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");

        rend = GetComponent<Renderer>();
        rend.material = new Material(rend.material);
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
     
        temperature = - dist + 30;
        alpha = - dist + 10;

        rend.material.SetFloat("_Alpha", alpha);
        rend.material.SetFloat("_Temperature", temperature);
    }
}
