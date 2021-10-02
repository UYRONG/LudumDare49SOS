using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Box: MonoBehaviour
{
    
    public abstract void interact(Cat c);

     void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        this.interact(col.gameObject.GetComponent<Cat>());
        Destroy(this.gameObject);
    }
    
}
