using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XFrameTimer : MonoBehaviour
{
    float countTime = 0;

    float oldAngle = 0;

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

        if (oldAngle == 0 && mv2.currentXAngle != 0)
        {
            countTime = 0;
            GetComponent<Text>().text = countTime.ToString("F2");
        }
        if (mv2.currentXAngle > -30 && mv2.currentXAngle < 30 && mv2.currentXAngle != 0)
        {
            // countTimeに、ゲームが開始してからの秒数を格納
            countTime += Time.deltaTime;

            // 小数2桁にして表示
            GetComponent<Text>().text = countTime.ToString("F2");

            if (mv2.vertical == 0)
            {
                countTime -= Time.deltaTime * 2;
                GetComponent<Text>().text = countTime.ToString("F2");
            }
        }
        oldAngle = mv2.currentXAngle;
    }
}
