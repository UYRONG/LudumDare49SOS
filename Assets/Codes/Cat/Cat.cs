using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0,9)]
    public int health;
    public CatState state ;
    public Animator animator;

    public int numOfFish;
    public bool isVisible;

    void Start()
    {
        initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void initialize(){
        health = 9;
        numOfFish = 0;
        state = CatState.Solid;
    }


    //Health
    public void addHealth(){
        if(health != 9){
            health++;
        }
    }


    public void reduceHealth(){
        if(health !=0){
            health --;
        }
    }

    //Fish
    public bool consumeFish(){
        if(numOfFish < 10){
            return false;
        }
        else{
            numOfFish -= 10;
            return true;
        }
    }

        public void pickFish(){
            numOfFish ++;
    }


    //Form
    public void changeForm(bool random){
        if(random){
            int r = Random.Range(0,3);
            this.state = (CatState) r;
        }
        else{
            this.state = (CatState)(((int)this.state + 1)%3);
        }
        this.isVisible = true;
        animator.SetInteger("State", (int)state);
    }

    public void teleport(Vector3 v){
        transform.position = v;
    }

    public void visible(){
        isVisible = true;
    }

    public void invisible(){
        isVisible = false;
    }

    public void toggleVisibility(){
        if(isVisible){
            invisible();
        }
        else{
            visible();
        }
    }

    public string getState(){
        switch(state){
            case CatState.Solid:
                return "Solid";
                break;
            case CatState.Liquid:
                return "Liquid";
                break;
            case CatState.Gas:
                return "Gas";
                break;
            default:
                return "";
        }
    }

}