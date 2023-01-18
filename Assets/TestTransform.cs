using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransform : MonoBehaviour
{
    public Transform transform;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            gameObject.transform.position = new Vector3(2f,2f,2f);
        }
    }
}
