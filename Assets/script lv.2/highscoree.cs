using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscoree : MonoBehaviour
{
    public GameObject skore;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "highscoree")
        {
            GetComponent<Text>().text = PlayerPrefs.GetInt("highscoree").ToString();
        }
    }
}
