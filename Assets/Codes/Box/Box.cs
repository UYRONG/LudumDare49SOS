using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Box: MonoBehaviour
{
    public AudioClip box_sound;    // Add your Audi Clip Here;
    public abstract void interact(Cat c);
    private AudioSource audioSource;

     void Start ()   
     {
         audioSource = GetComponent<AudioSource> ();
         audioSource.playOnAwake = false;
         audioSource.clip = box_sound;
     }

    void OnCollisionEnter2D(Collision2D col)
    {
        //TODO: Enable at the last
        // audioSource.Play();
        this.interact(col.gameObject.GetComponent<Cat>());
        Destroy(this.gameObject,0.3f);
    }
    
}
