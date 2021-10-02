using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cat : MonoBehaviour
{
    private int currHealth;
    public HealthBar HB;
    public SpriteRenderer SR;
    public DateTime disappear = DateTime.Now;

    // Start is called before the first frame update
    void Start()
    {        
        // testing heathbar
        currHealth = 9;
    }

    void OnCollisionEnter2D(Collision2D col)        
    {
        float num = UnityEngine.Random.value;
        var currTime = System.DateTime.Now;


        if(num < 0.5)
        {
            disappear = DateTime.Now;
            SR.enabled = false;
            currHealth--;
        }  
    }

    // Update is called once per frame
    void Update()
    {
        if((DateTime.Now - disappear).Seconds > 3)
        {
            SR.enabled = true;
        }

        HB.setHealth(currHealth);

        // testing heathbar
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-150 * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(150 * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -150 * Time.deltaTime, 0);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 150 * Time.deltaTime, 0);
        }
    }
}
