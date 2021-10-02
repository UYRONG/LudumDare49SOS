using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private int currHealth;
    public HealthBar hb;

    // Start is called before the first frame update
    void Start()
    {        
        // testing heathbar
        currHealth = 9;
    }

    // Update is called once per frame
    void Update()
    {

        // testing heathbar
        if(Input.GetKeyDown(KeyCode.Space))
        {
            currHealth--;
            hb.setHealth(currHealth);
        }
    }

}
