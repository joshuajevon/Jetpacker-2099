using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemscopy : MonoBehaviour
{
    float time = 0;
    float timer = 20;
    public GameObject gems;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            Instantiate(gems, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
