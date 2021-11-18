using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmanezya : MonoBehaviour
{
    private AudioSource audioSouce;
    // Start is called before the first frame update
    void Start()
    {
        audioSouce = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
