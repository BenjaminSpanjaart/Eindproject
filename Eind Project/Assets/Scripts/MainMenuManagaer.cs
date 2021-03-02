using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManagaer : MonoBehaviour
{

    public void OnClickStart()
    {
        SceneManager.LoadScene("Prototype1");
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }
}
