using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenManager : MonoBehaviour
{  
    private void Start()
    {
        Mouse();
    }
    public void Scene1()
    {  
        
        SceneManager.LoadScene("Respawn");  
        
        Debug.Log("Button was clicked");
    }  
    public void Scene2()
    {  
        SceneManager.LoadScene("MainMenu");  
    }  
    public void Mouse()
    {
        Debug.Log("Check");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible=true;
    }
}