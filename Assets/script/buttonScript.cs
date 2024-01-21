using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class buttonScript : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(play_func);
        quitButton.onClick.AddListener(quit_func);
    }

    void play_func()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Play");
    }

    void quit_func()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}


