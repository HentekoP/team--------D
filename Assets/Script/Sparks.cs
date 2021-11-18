using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparks : MonoBehaviour
{
    public ParticleSystem spk;
    public ParticleSystem fls;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Spark(collision);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Coin")
        {
            Flash(collider.gameObject);
        }
    }
    void Spark(Collision collision)
    {
        spk.transform.position = collision.contacts[0].point;
        spk.Play();
    }

    void Flash(GameObject obj)
    {
        fls.transform.position = this.transform.position;
        fls.Play();
        Destroy(obj);
    }
}
