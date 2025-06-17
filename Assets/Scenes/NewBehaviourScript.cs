using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    //load Scene
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    //load Quit
    public void View()
    {
        SceneManager.LoadScene("View Cards");
        //Application.Quit();
        //Debug.Log("Exited From The Game.");
    }
}
