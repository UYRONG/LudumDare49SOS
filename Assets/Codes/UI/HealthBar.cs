using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Cat cat;

    public Text health;
    public Text fishes;
    
    public Instructions ins;

    private int currLevel;
    private bool firstBox = true;
    private bool firstCucumber = true;
    private bool firstFish = true;

    public int f, h;
    // Update is called once per frame
    void Update()
    {
        setHealth(h);
        setFish(f);
        /*setHealth(cat.health);
        setFish(cat.fishes);*/
    }

    /*bool checkEnd()
    {
        if(currLevel == && cat.health > 0)
        {
            Debug.Log("success");
            // show game end scene (thank you, play again?)
        }
        else if (currLevel < )
        {
            Debug.Log("Next level page")
        }
        else
        {
            Debug.Log("Lose, play again?")
        }
    }*/

    void getInstruction(int index)
    {
        if(index == 0 || index == 1)
        {
            ins.getInstruction(index);
        }
        else if(index == 2 && firstBox)
        {
            ins.getInstruction(index);
            firstBox = false;
        }
        else if(index == 3 && firstCucumber)
        {
            ins.getInstruction(index);
            firstCucumber = false;
        }
        else if(index == 4 && firstFish)
        {
            ins.getInstruction(index);
            firstFish = false;
        }
    }

    void setHealth(int h)
    {
        this.health.text = "x " + h.ToString();
    }

    void setFish(int f)
    {
        this.fishes.text = "x " + f.ToString();
    }

}
