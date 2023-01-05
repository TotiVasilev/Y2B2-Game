using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeadingArrow : MonoBehaviour
{
    GameObject endOfArrow;
    GameObject player;
    Renderer rend;

    float fullGlow = 60;
    public float lightTime = 10;
    float glow;

    //public float temperature;
    public float origin;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        endOfArrow = GameObject.FindWithTag("Checkpoint");

        rend = GetComponent<Renderer>();
        rend.material = new Material(rend.material);
        glow = fullGlow;
        rend.material.SetFloat("_Glow", glow);
        StartCoroutine(EmissionUp());
    }

    // Update is called once per frame
    void Update()
    {

        float dist = Vector3.Distance(player.transform.position, endOfArrow.transform.position);

        //float glow = Time.deltaTime * dist;     

        //temperature = - dist + 30;
        origin = - dist + 5 ;

        rend.material.SetFloat("_Origin", origin);
        rend.material.SetFloat("_Glow", glow);
        //rend.material.SetFloat("_Temperature", temperature);
    }


    // Coroutines that make the emmision go up and down constantly/repeatedly 
    IEnumerator EmissionUp()
    {
        while (glow > 0){
            glow -= lightTime * Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(EmissionDown());
    }

    IEnumerator EmissionDown()
    {
        while (glow < 60)
        {
            glow += lightTime * Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(EmissionUp());
    }
}
