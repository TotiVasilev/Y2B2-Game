using UnityEngine;

public class TemperatureValue : Temperature
{
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Raise();
            Lower();
        }
    }
}
