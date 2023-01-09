using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S_StartDoorGlow : MonoBehaviour
{
    Renderer rend;

    public GameObject interactableDoor;

    float fullGlow = 0.01f;
    public float lightTime = 0.001f;
    float glow;

    void Awake()
    {

        rend = interactableDoor.GetComponent<Renderer>();
        rend.material = new Material(rend.material);

        glow = fullGlow;
        rend.material.SetFloat("_Highlight", glow);
        
    }
    private void Update()
    {
        rend.material.SetFloat("_Highlight", glow);
    }


    public IEnumerator EmissionUp()
    {
        while (glow > 0.003)
        {
            glow -= lightTime * Time.deltaTime;
            yield return null;
        }
        //yield return new WaitForSeconds(0.5f);
        StartCoroutine(EmissionDown());
    }

    IEnumerator EmissionDown()
    {
        while (glow < 0.007)
        {
            glow += lightTime * Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(EmissionUp());
    }
}
