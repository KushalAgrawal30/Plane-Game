using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisonPlane : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject score_screen;
    public GameObject pause_menu; 

    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "building":
                Debug.Log("Bumped into building");
                crashSequence();
                break;
            default:
                Debug.Log("Bumbed into ground");
                crashSequence();
                break;
        }
    }


    void crashSequence()
    {
        score_screen.SetActive(false);
        GetComponent<movement>().enabled = false;
        Time.timeScale = 0f;
        gameOver.SetActive(true);
        pause_menu.GetComponent<PauseMenu>().enabled = false;
    }
}
