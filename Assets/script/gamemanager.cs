using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public GameObject panelPause;

    public void PauseControl()
    {
        if(Time.timeScale == 1)
        {
            panelPause.SetActive(true);
            Time.timeScale = 0;

        }
        else
        {
            Time.timeScale = 1;
                panelPause.SetActive(false);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void MenuUtama() { Application.LoadLevel(2);
        Time.timeScale = 1;
    }

    public void level()
    {
        Application.LoadLevel(3);
        Time.timeScale = 1;
    }
}
