using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalArrow : MonoBehaviour
{

    [SerializeField]
    private Transform target;

    private void Update()
    {
        Vector3 targetPositon = target.transform.position;
        targetPositon.y = transform.position.y;
        transform.LookAt(target);
    }
}
