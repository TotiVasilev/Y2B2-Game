using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceenShader : MonoBehaviour
{
    public Material material;
    /*  [SerializeField] private float blinkFrequency = 2f;
      Material material;
      private float timer;

      // Start is called before the first frame update */
    void Start()
    {
        material.SetFloat("_FullscreenIntensity", 0.4f);
    }
    void OnApplicationQuit()
    {
        material.SetFloat("_FullscreenIntensity", 0);
    }
            /*
          white = SharderGraphs.Load<Material>("Material/Material_Fullscreen_Test");
          red = SharderGraphs.Load<Material>("Material/Red");
      }

      // Update is called once per frame
      void Update()
      {
          timer -= Time.deltaTime;
          if (timer <= 0)
          {
              timer = 1 / blinkFrequency;

              blinkObject = !blinkObject;
              foreach (var child in rend_ThisObject)
              {
                  child.material = blinkObject ? white : red;
              }
          }
      }*/
}
