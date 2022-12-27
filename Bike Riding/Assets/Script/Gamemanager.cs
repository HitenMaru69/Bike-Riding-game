using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    bool isgameend = false;

    public void Nextlevel()
    {
        if(isgameend == false)
        {
            isgameend = true;
            Invoke("Loadlevel", 1f);
        }
        
    }

    public void Currentlevel()
    {
        if (isgameend == false)
        {
            isgameend = true;
            Invoke("Loadcurrent", 1f);
        }

    }

    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }

    




    void Loadlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    void Loadcurrent()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    
        
    
}
