using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadScene (string scenName ){
        SceneManager.LoadScene(scenName);
    }

    public void QuitApp(){
        Debug.Log("Quit");
        Application.Quit();
    }
}

