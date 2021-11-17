using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//スローでRigidBodyの挙動を確認してみた所接触があった際めり込んだ後跳ね返った
//なのでCollisionEnter内では力だけ変えて座標更新は行わない

public class LigitBody : MonoBehaviour
{

    [SerializeField] private float mass;
    [SerializeField] private bool usegravity;
    [SerializeField] private bool iskinematic;

    [HideInInspector] public Vector3 force;//掛かってる力


    void Start()
    {
        //Time.timeScale = 0.1f;
    }

    void FixedUpdate()
    {
        force += Physics.gravity * Time.deltaTime;//プロパティの重力は力の値にどう加えるのが正しいかTestに新しいシーンを作ってテストしてみたい
        transform.position+=force * Time.deltaTime;
        //衝突判定から
    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("hit");
        force *= -1;
    }
}
