using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    

    public AudioClip clip;
    private int score;
    void Start()
    {

    }


    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Ball"))
        {
            // Instantiate(particleObject, this.transform.position, Quaternion.identity);
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position); 
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position); 
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position); 
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip, transform.position);



        }
      }
    }
