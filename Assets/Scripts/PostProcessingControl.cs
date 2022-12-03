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
    public Volume outOfSmoke;
    public VolumeProfile[] profiles;

    public ParticleSystem[] SmokePart;


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
            StartCoroutine(InOfSmoke());
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
            Gradient grad = new Gradient();
            grad.SetKeys(
                new GradientColorKey[] {
            new GradientColorKey(Color.white, 0.0f),
            new GradientColorKey(Color.white, 1.0f) },
                new GradientAlphaKey[] {
            new GradientAlphaKey(1, 0.0f),
            new GradientAlphaKey(1, 1.0f) });

            //SmokePart[0]. = grad;
            //SmokePart[0].startColor = seeThroughSmoke;
            SmokePart[0].startSize = 1f;
            outOfSmoke.profile = profiles[1];
            inSmoke.profile = profiles[1];
            ison = true;
            insmoke = false;
        }
        else
        if (ison == true)
        {
            SmokePart[0].startSize = 4f;
            ison = false;
            inSmoke.profile = profiles[0];
            outOfSmoke.profile = profiles[2];
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
