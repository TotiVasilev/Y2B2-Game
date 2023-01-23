using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenManager : MonoBehaviour
{  
    public void Scene1()
    {  
        SceneManager.LoadScene("New Prototype");  
    }  
    public void Scene2()
    {  
        SceneManager.LoadScene("MainMenu");  
    }  
}