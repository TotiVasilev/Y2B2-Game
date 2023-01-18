using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positionscript : MonoBehaviour
{
    [SerializeField] GameObject character;
    [SerializeField] List<GameObject> checkPoints;
    [SerializeField] Vector3 vectorPoint;
    
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

       if (Input.GetKey(KeyCode.F))
        {
            character.transform.position = vectorPoint;
            //gameObject.transform.position = new Vector3(5.53f,0.92f,3.12f);
            //animator.SetTrigger("Vault");
        }
    }   

    private void OnTriggerEnter(Collider other)
    {
        vectorPoint = character.transform.position;
        Destroy(other.gameObject);
    }
}