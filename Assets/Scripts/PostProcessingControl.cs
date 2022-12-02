using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Timeline;

public class PostProcessingControl : MonoBehaviour
{
    public Material material;
    public float maxSmoke = 0.4f;
    public float minSmoke = 0f;

    public Volume inSmoke;
    public VolumeProfile[] profiles;



    public bool ison = false;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           TurnOnVision();
        }   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && material.GetFloat("_FullscreenIntensity") == 0f)
        {
            StartCoroutine(InOfSmoke());
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && material.GetFloat("_FullscreenIntensity") >= 0.3f)
        {
            StartCoroutine(OutOfSmoke());
        }
    }

    void TurnOnVision()
    {
        if (ison == false)
        {
            inSmoke.profile = profiles[1];
            ison = true;
        }
        else
        if (ison == true)
        {
            ison = false;
            inSmoke.profile = profiles[0];
        }
    }

    IEnumerator InOfSmoke()
    {
        material.SetFloat("_FullscreenIntensity", 0.1f);
        yield return new WaitForSeconds(0.4f);
        material.SetFloat("_FullscreenIntensity", 0.2f);
        yield return new WaitForSeconds(0.4f);
        material.SetFloat("_FullscreenIntensity", 0.3f);
        yield return new WaitForSeconds(0.4f);
        material.SetFloat("_FullscreenIntensity", 0.4f);
        yield return new WaitForSeconds(0.4f);
    }

    IEnumerator OutOfSmoke()
    {
        material.SetFloat("_FullscreenIntensity", 0.3f);
        yield return new WaitForSeconds(0.4f);
        material.SetFloat("_FullscreenIntensity", 0.2f);
        yield return new WaitForSeconds(0.4f);
        material.SetFloat("_FullscreenIntensity", 0.1f);
        yield return new WaitForSeconds(0.4f);
        material.SetFloat("_FullscreenIntensity", 0f);
        yield return new WaitForSeconds(0.4f);
    }
}
