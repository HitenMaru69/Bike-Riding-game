using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        Invoke("play", 1f);
    }

    public void Quit()
    {
        Invoke("quit", 1f);

    }

    public void Level()
    {
        Invoke("lec", 1f);
    }


    void play()
    {
        SceneManager.LoadScene("Level");
    }

    void quit()
    {
        Application.Quit();
    }

    void lec()
    {
        SceneManager.LoadScene("Menu1");
    }
   
}
