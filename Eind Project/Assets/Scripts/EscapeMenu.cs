using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeMenu : MonoBehaviour
{
    [SerializeField] private GameObject Escape;
    [SerializeField] private GameObject Options;
    GameObject opt;
    GameObject esc;
    private SceneManagment Scenes;
    private void Start()
    {
        GameObject scenemanager = GameObject.Find("SceneManager");
        Scenes = scenemanager.GetComponent<SceneManagment>();
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !GameObject.Find("EscMenu"))
        {
            esc = GameObject.Instantiate(Escape);
        }else
        {
            GameObject.Destroy(esc);
            if (GameObject.Find("OptionsMenu"))
            {
                GameObject.Destroy(opt);
            }
        }
    }
    public void OptionsMenu()
    {
        if (!GameObject.Find("OptionsMenu"))
        {
            opt = GameObject.Instantiate(Options);
        }
        else
        {
            GameObject.Destroy(opt);
        }
    }
    public void QuitToMenu()
    {
        Scenes.StartScene();
    }
}
