using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    private string[] instructions = {"Press Arrow Keys to Move", "Press Space Bar to Jump", "Hmm, what do these boxes do?"};
    public Text display;
    private int index = 0;
    private System.DateTime curr;
    private bool pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        nextInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        if(!display.enabled)
        {
            nextInstruction();
        }
        
        if(pressed  && (System.DateTime.Now - curr).Seconds >= 2)
        {
            display.enabled = false;
            pressed = false;
        }
    }

    void nextInstruction()
    {        
        if(index < 3)
        {
            display.text =  instructions[index];
            display.enabled = true;
            index++;
        }
    }

    void FixedUpdate()
    {
        switch(index)
        {
            case 1: 
                if(!pressed && (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)))
                {
                    curr = System.DateTime.Now;
                    pressed = true;
                }      
                break;

            case 2: 
                if(!pressed && (Input.GetKeyDown(KeyCode.Space)))
                {
                    curr = System.DateTime.Now;
                    pressed = true;    
                }
                break;
            default: 
                curr = System.DateTime.Now;
                pressed = true;
                break;
        }
    }
}
