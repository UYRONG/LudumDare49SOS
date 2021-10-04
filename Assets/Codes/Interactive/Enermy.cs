using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{

    public float leftx;
    public float rightx;
    [SerializeField] float speed = 4 ;
    [SerializeField] bool MoveRight;

    // Update is called once per frame

    System.DateTime lastActionTime;
    // Start is called before the first frame update
    void Start()
    {
        lastActionTime = System.DateTime.Now;
    }
    void Update()
    {   
        if (MoveRight){
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        }
        else{
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
        
        if(this.transform.position.x < leftx || this.transform.position.x >rightx ){
            Debug.Log("OK");
            if (MoveRight){
                MoveRight = false;
            }
            else{
                MoveRight = true;
            }
        }

                
    }

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        if ((System.DateTime.Now - lastActionTime).TotalSeconds > 1){
            Cat cat = col.gameObject.GetComponent<Cat>();
            if(cat.isVisible || cat.state != CatState.Gas){
                lastActionTime = System.DateTime.Now;
                cat.reduceHealth();
            }
        }
    
    
    }
}
