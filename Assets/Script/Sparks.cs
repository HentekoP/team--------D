using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparks : MonoBehaviour
{
    public ParticleSystem spk;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ball")
        {
            spk.Play();
        }
    }
}
