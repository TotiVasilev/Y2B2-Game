using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eispressed : MonoBehaviour

{   
    [SerializeField] GameObject player1;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
       if (Input.GetKey(KeyCode.V))
        {
            
            animator.SetTrigger("Attack");
        }

        if (Input.GetKey(KeyCode.F))
        {
            
            gameObject.transform.position = new Vector3(5.53f,0.92f,3.12f);
            animator.SetTrigger("Vault");
            //animator.enabled =true;

            //StartCoroutine(VaultWindow());
            
    
        }
        
    }
}
