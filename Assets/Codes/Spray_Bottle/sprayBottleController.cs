using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprayBottleController : MonoBehaviour
{
    System.DateTime lastActionTime;
    // Start is called before the first frame update
    void Start()
    {
        lastActionTime = System.DateTime.Now;
        Debug.Log("GIAO");
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if ((System.DateTime.Now - lastActionTime).TotalSeconds > 1){
            Debug.Log("GIAO");
            lastActionTime = System.DateTime.Now;
            Cat c = col.gameObject.GetComponent<Cat>();
            c.reduceHealth();
        }
    }

}
