using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore1 : MonoBehaviour
{
    public GameObject skor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "highscore")
        {
            GetComponent<Text>().text = PlayerPrefs.GetInt("highscore").ToString();
        }
    }
}
