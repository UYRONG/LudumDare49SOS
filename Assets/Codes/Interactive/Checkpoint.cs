using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        FindObjectOfType<GameManager>().reachCheckpoint();
    }
}
