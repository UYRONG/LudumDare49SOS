using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    private string[] instructions = {"Press Arrow Keys to Move", "Press Space Bar to Jump", "Hmm, what do these boxes do?", "Ewww, don't touch that cucumber"};
    public Text display;
    private int index = -1;
    private System.DateTime curr;


    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.index);
        if(Input.GetKeyDown(KeyCode.Q))
        {
            getInstruction(0);
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            getInstruction(1);
        }


        if(Input.GetKeyDown(KeyCode.E))
        {
            getInstruction(2);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            getInstruction(3);
        }

        switch(index)
        {
            case -1: break;
            case 0:
                if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    display.enabled = false;
                    this.index = -1;
                }
                break;

            case 1:
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    display.enabled = false;
                    this.index = -1;
                }
                break;

            case 2: case 3:
                if((System.DateTime.Now - curr).Seconds >= 3)
                {
                    display.enabled = false;
                    this.index = -1;
                }
                break;
        }
    }

    void getInstruction(int ind)
    { 
        // move: 0, jump 1, box 2, cucumber 3
        display.text =  instructions[ind];
        display.enabled = true;
        curr = System.DateTime.Now;
        this.index = ind;
    }
}
