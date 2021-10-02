using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0,9)]
    public int health;
    public CatState state ;

    public int numOfFish;

    void Start()
    {
        
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

    public void teleport(Vector2 v){
        transform.position = v;
    }

    public void addHealth(){
        if(health != 9){
            health++;
        }
    }

    public bool consumeFish(){
        if(numOfFish < 10){
            return false;
        }
        else{
            numOfFish -= 10;
            return true;
        }
    }

    public void reduceHealth(){
        if(health !=0){
            health --;
        }
    }
}
