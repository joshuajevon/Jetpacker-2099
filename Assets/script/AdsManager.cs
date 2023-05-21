using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize("4166109");
    }

    public void PlayAd()
    {
        if (Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
        }
    }
}
