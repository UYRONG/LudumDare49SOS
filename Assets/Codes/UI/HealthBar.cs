using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private int health = 9;
    
    public Image[] hearts;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            takeDamage();
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            heal();
        }
    }

    void takeDamage()
    {
        if(health > 0)
        {
            hearts[health - 1].enabled = false;
            health--;
        }
    }

    void heal()
    {
        if(health < 9)
        {
            hearts[health].enabled = true;
            health++;
        }
    }
}
