using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermovementlv2 : MonoBehaviour
{
    Rigidbody2D Rb;
    public float jumpForce, weight;

    public AdsManager ads;
    public GameObject ad;

    public GameObject loser, tutor,skore;
    public GameObject tryagain,level, highscoree;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            Rb.gravityScale = weight;
            Rb.velocity = Vector2.up * jumpForce;
            tutor.SetActive(false);
            GameObject.Find("jump").GetComponent<AudioSource>().Play();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            skore.GetComponent<skore>().score++;
            GameObject.Find("CLINK").GetComponent<AudioSource>().Play();
           
        }
        if (collision.gameObject.tag == "building")
        {
            Destroy(gameObject);
            tutor.SetActive(false);
            loser.SetActive(true);
            tryagain.SetActive(true); 
            level.SetActive(true);
            ad.SetActive(true);
            highscoree.SetActive(true);
            if (PlayerPrefs.GetInt("highscoree") < skore.GetComponent<skore>().score)
            {
                PlayerPrefs.SetInt("highscoree", skore.GetComponent<skore>().score);
            }
            GameObject.Find("nub").GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject.tag == "atasbawah")
        {
            Destroy(gameObject);
            tutor.SetActive(false);
            loser.SetActive(true);
            tryagain.SetActive(true);
            level.SetActive(true);
            highscoree.SetActive(true);
            ad.SetActive(true);

            if (PlayerPrefs.GetInt("highscoree") < skore.GetComponent<skore>().score)
            {
                PlayerPrefs.SetInt("highscoree", skore.GetComponent<skore>().score);
            }
            GameObject.Find("nub").GetComponent<AudioSource>().Play();
            ads.PlayAd();


        }
    }
}
