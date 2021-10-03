using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Cat cat;

    public Text health;
    public Text fishes;
    
    public Instructions ins;

    private int currLevel;

    private bool[] firsts = new bool[] {true, true, true, true, true};

    private int counter = 0;
    // Update is called once per frame

    void Start()
    {
        cat = FindObjectOfType<Cat>();
        getInstruction(0);
        counter++;
    }

    void Update()
    {
        setHealth(cat.health);
        setFish(cat.numOfFish);

        if(ins.index == -1 && counter == 1)
        {
            getInstruction(1);
            counter++;
        }
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

    public void getInstruction(int index)
    {
        if(firsts[index])
        {
            ins.getInstruction(index);
            firsts[index] = false;
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
