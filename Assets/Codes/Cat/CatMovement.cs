using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{

    public Cat cat;
    public CatController catController;
    public CatFormController catFormController;
    public Animator animator;
    public float runSpeed = 50f;
    float horizontalMove = 0f;

    bool jump = false;

    void Update(){

        if(cat.state != CatState.Gas || cat.isVisible){
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        }
        if(Input.GetButtonDown("Jump") && cat.state == CatState.Solid){
            jump = true;
        }
        else if(Input.GetButtonDown("Jump") && cat.state == CatState.Gas && horizontalMove == 0){
            catFormController.changeVisibility();
        }
        if(Input.GetKeyDown(KeyCode.Q) && cat.numOfFish > 0 && (cat.state!= CatState.Gas || cat.state == CatState.Gas && cat.isVisible)){
            catFormController.changeForm(false);
            cat.numOfFish--;
        }
        if(Input.GetKeyDown(KeyCode.E)){
            cat.pray();
        }
    }

    void FixedUpdate(){
        catController.Move(horizontalMove* Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
