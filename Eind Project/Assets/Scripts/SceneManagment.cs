using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneManagment : MonoBehaviour
{
    [SerializeField] private GameObject ConfirmationBox;
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(ConfirmationBox);
    }

    public void GameScene()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void EndGameScene() 
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void StartScene()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void QuitGameConfirm()
    {
        ConfirmationBox.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void DontQuit()
    {
        ConfirmationBox.SetActive(false);
    }

}
