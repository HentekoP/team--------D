using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparks : MonoBehaviour
{
    public ParticleSystem spk;

    void Update()
    {
        Debug.Log("呼ばれた");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("触った");
        if (collision.gameObject.tag == "Wall")
        {
            spk.transform.position = collision.contacts[0].point;
            spk.Play();
        }
    }
}
