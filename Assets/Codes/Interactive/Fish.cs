using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        FindObjectOfType<GameManager>().getInstruction(4);

        Cat cat = col.gameObject.GetComponent<Cat>();
        cat.pickFish();
        Destroy(this.gameObject);
    }
}
