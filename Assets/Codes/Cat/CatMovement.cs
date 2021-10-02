using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{

    public CatController catController;
    public float runSpeed = 40f;
    float horizontalMove = 0f;

    bool jump = false;

    void Update(){

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump")){
            jump = true;
        }
    }

    void FixedUpdate(){
        catController.Move(horizontalMove* Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}