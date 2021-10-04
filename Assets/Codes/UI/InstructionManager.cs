using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InstructionManager: MonoBehaviour
{
    [Header("UI Object")]
    public Text display;

    [Header("Data Obeject")]
    public Cat cat;
    public GameObject first_box_pos;
    public GameObject first_fish_pos;
    public GameObject first_enemy_pos;


    public int index = 0;

    private string[] instructions = {"Press Arrow Keys to Move", 
                                     "Press Space Bar to Jump",
                                     "Hmm, what do these boxes do?", 
                                     "Ewww, don't touch that cucumber", 
                                     "Mmmm, that fish looks delicious, collect some"};


    void Start()
    {
        _displayInstruction(index, false);
    }
    
    public void Update(){
        displayInstruction();
    }


    void displayInstruction(){
        switch(index)
        {
            case -1: break;
            case 0:
                if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    index++;
                    _displayInstruction(index, false);
                }
                break;

            case 1:
                if(Input.GetKeyDown(KeyCode.Space))
                {
                     _displayInstruction(index, false);
                    index++;
                }
                break;

            case 2: 
                if(Vector2.Distance(cat.transform.position, first_box_pos.transform.position)< 1f){
                    _displayInstruction(index, true);
                    index++;
                }
                break;
            
            case 3: 
                if(Vector2.Distance(cat.transform.position, first_enemy_pos.transform.position)< 1f){
                    _displayInstruction(index, true);
                    index++;
                }
                break;
            case 4:
                if(Vector2.Distance(cat.transform.position, first_fish_pos.transform.position)< 1f){
                    _displayInstruction(index, true);
                    index++;
                }
                break;
        }
    }

    public void _displayInstruction(int ind, bool disappear)
    { 
        // move: 0, jump 1, box 2, cucumber 3, fish 4
        display.text =  instructions[ind];
        display.enabled = true;
        if(disappear){
           StartCoroutine(DisapeearAfter3Second());
        }
    }

    IEnumerator DisapeearAfter3Second()
    {
        yield return new WaitForSeconds(1);
        display.enabled = false;
        distorySelf();
    }
    public void distorySelf(){
        if(index==5){
            Destroy(this.gameObject);
        }
    }

}
