using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{

    public Cat cat;
    public CatController catController;
    public Animator animator;
    public float runSpeed = 40f;
    float horizontalMove = 0f;

    bool jump = false;

    void Update(){

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump") && cat.state == CatState.Solid){
            jump = true;
        }
        else if(Input.GetButtonDown("Jump") && cat.state == CatState.Gas){
            cat.toggleVisibility();
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