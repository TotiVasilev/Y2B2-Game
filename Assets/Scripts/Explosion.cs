using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public ParticleSystem explosionExample;
    public CameraShake cameraShake;

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            explosionExample.Play();
            StartCoroutine(cameraShake.Shake(.20f, .3f));
        }
    }
}
