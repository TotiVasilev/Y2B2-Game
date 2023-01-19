using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public Light Flight;
    private float floatIntensity;
    public float minIntensity;
    public float maxIntensity;
    public float speed;

    public IEnumerator ChangeIntensity()
    {
        while (true)
        {
            if (floatIntensity <= minIntensity)
            {
                while (floatIntensity < maxIntensity)
                {
                    floatIntensity += speed * Time.deltaTime;
                    yield return null;

                }
            }
            else
            {
                while (floatIntensity > minIntensity)
                {
                    floatIntensity -= speed * Time.deltaTime;
                    yield return null;

                }
            }
            yield return null;

        }
    }
    public void Update()
    {
        Flight.intensity = floatIntensity;
    }
    public void Start()
    {
        StartCoroutine(ChangeIntensity());
    }
}
