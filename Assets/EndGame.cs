using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(SceneChange());
        }     
    }

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneName: "Outro");
    }
}
