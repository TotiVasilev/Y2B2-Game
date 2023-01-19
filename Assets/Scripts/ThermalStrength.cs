using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class ThermalStrength : MonoBehaviour
{
    GameObject player;
    Renderer rend;

    [SerializeField]
    private float temperature;
    [SerializeField]
    private float alpha;
    [SerializeField]
    private int materialIndex;
    Renderer myRenderer;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        myRenderer = GetComponent<Renderer>();
    //    rend = GetComponent<Renderer>();
    //    rend.material = new Material(rend.material);
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
     
        temperature = - dist + 50;
        alpha = - dist + 30;

        myRenderer.materials[materialIndex].SetFloat("_Alpha", alpha);
        myRenderer.materials[materialIndex].SetFloat("_Temperature", temperature);
    }
}
