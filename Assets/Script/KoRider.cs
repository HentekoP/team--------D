using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoRider : MonoBehaviour
{
    [SerializeField] private bool is_trigger;
    [SerializeField] private Vector3 center;
    [SerializeField] private Vector3 size;

    public float bounce;
    [SerializeField] private BoundCombo bounce_combine;
    // Start is called before the first frame update
    void Start()
    {
        //p_material.bounciness;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
