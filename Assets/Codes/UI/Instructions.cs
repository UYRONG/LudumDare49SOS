using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    private string[] instructions = {"Press Arrow Keys to Move", 
                                     "Press Space Bar to Jump",
                                     "Hmm, what do these boxes do?", 
                                     "Ewww, don't touch that cucumber", 
                                     "Mmmm, that fish looks delicious, collect some"};
    public Text display;
    public int index = 0;
    private System.DateTime curr;


    // Update is called once per frame
    void Update()
    {
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

            case 2: case 3: case 4:
                if((System.DateTime.Now - curr).Seconds >= 3)
                {
                    display.enabled = false;
                    this.index = -1;
                }
                break;
        }
    }

    public void getInstruction(int ind)
    { 
        // move: 0, jump 1, box 2, cucumber 3, fish 4
        display.text =  instructions[ind];
        display.enabled = true;
        curr = System.DateTime.Now;
        this.index = ind;
    }
}
