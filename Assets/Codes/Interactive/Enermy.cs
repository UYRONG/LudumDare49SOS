using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        Cat cat = col.gameObject.GetComponent<Cat>();
        if(cat.isVisible || cat.state != CatState.Gas){
            cat.reduceHealth();
        }

    }
}
