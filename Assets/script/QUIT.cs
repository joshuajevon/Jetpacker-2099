using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUIT : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
