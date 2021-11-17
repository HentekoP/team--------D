using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameTimer : MonoBehaviour
{
    float countTime;

    [SerializeField]
    GameObject ground;

    MoveGround2 mv2;

    // Use this for initialization
    void Start()
    {
       
        mv2 = ground.GetComponent<MoveGround2>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Invoke("countTime.time{0}", Time.time);
        // countTimeに、ゲームが開始してからの秒数を格納
        countTime += Time.deltaTime;

        // 小数2桁にして表示
        GetComponent<Text>().text = countTime.ToString("F2");
        PlayerPrefs.SetFloat("time_max",countTime);
        


    }
}
