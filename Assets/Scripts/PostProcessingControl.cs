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
   

    public Material[] smokeVisual;
    public Renderer[] rend;
    

    public Volume inSmoke;
    public Volume outOfSmoke;
    public VolumeProfile[] profiles;

 
    public bool ison = false;
    public bool insmoke = false;
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

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && material.GetFloat("_FullscreenIntensity") >= 0f && ison == false && insmoke == false)
        {
            StartCoroutine(InSmoke());
            insmoke = true;
        }
        
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && material.GetFloat("_FullscreenIntensity") >= 0.3f && ison == false)
        {
            StartCoroutine(OutOfSmoke());
            insmoke = false;
        }
        
    }

    void TurnOnVision()
    {
        material.SetFloat("_FullscreenIntensity", 0f);

        if (ison == false)
        {
            rend[0].sharedMaterial = smokeVisual[1];
            outOfSmoke.profile = profiles[1];
            inSmoke.profile = profiles[1];
            ison = true;
            insmoke = false;
        }
        else
        if (ison == true)
        {
            rend[0].sharedMaterial = smokeVisual[0];
            ison = false;
            inSmoke.profile = profiles[0];
            outOfSmoke.profile = profiles[2];
        }
    }

    IEnumerator InSmoke()
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
