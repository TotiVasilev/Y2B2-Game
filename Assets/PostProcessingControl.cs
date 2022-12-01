using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostProcessingControl : MonoBehaviour
{
    public Volume inSmoke;
    public VolumeProfile[] profiles;

    //WhiteBalance whiteBalance;



    public bool ison = false;
    void Start()
    {
        //inSmoke.profile.TryGet<WhiteBalance>(out whiteBalance);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           TurnOnVision();
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
            inSmoke.profile = profiles[0    ];
        }
    }
}
