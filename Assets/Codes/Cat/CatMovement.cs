using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{

    public Cat cat;
    public CatController catController;
    public float runSpeed = 40f;
    float horizontalMove = 0f;

    bool jump = false;

    void Update(){

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump")){
            jump = true;
        }
        if(Input.GetKeyDown(KeyCode.Q)){
            Debug.Log("Change form");
            cat.changeform(false);
            
        }
    }

    void FixedUpdate(){
        catController.Move(horizontalMove* Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}