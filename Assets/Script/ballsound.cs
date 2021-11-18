using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballsound : MonoBehaviour
{
    private AudioSource audio;

    public AudioClip sound01;
    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
       
            audio.PlayOneShot(sound01);
        
    }
}
