using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostProcessingControl : MonoBehaviour
{
    public Volume inSmoke;
    // Start is called before the first frame update
    void Start()
    {
        WhiteBalance whiteBalance;

        if (inSmoke.profile.TryGet<WhiteBalance>(out whiteBalance))
        {
            whiteBalance.temperature.value = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
