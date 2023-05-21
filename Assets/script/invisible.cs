using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisible : MonoBehaviour
{
    private SpriteRenderer character;
    private Color col;
    private float activationTime;
    private bool power;
   

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<SpriteRenderer>();
        activationTime = 0;
        power = false;
        col = character.color;
    }

    // Update is called once per frame
    void Update()
    {
        activationTime += Time.deltaTime;
        if(power && activationTime >= 3)
        {
            power = false;
            col.a = 1;
            character.color = col;
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "invisible")
        {
            power = true;
            activationTime = 0;
            col.a = .2f;
            character.color = col;
           
            other.gameObject.SetActive(false);
        }
    }
}
