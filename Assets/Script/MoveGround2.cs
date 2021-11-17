using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround2 : MonoBehaviour
{
    float x;
    float z;

    // GameObjectのZ軸方向の角度を取得
   public float currentZAngle;
    //GameObjectのX軸方向の角度を取得
   public  float currentXAngle;

    //左右キーの入力を取得する変数
    public float horizontal;
    //上下キーの入力を取得する変数
    public float vertical;

    int bkc_count;


    void Start()
    {
        currentZAngle = transform.eulerAngles.z;
        currentXAngle = transform.eulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        //int p = 20;

        // 左右キーの入力を取得
         horizontal = Input.GetAxis("Horizontal")*-1;
        //上下キーの入力を取得
         vertical = Input.GetAxis("Vertical");

        currentZAngle = transform.eulerAngles.z;
        currentXAngle = transform.eulerAngles.x;

        //現在の角度が180より大きい場合
        if (currentXAngle > 180)
        {
            // デフォルトでは角度は0～360なので-180～180となるように補正
            currentXAngle = currentXAngle - 360;
        }

        //X軸の回転処理(上ボタン）
        if (vertical > 0)
        {
            if (currentXAngle < 30)
            {
                x += Time.deltaTime * 20;//90f
                
            }
            else
            {
                x = 30;
            }
            transform.rotation = Quaternion.Euler(x, 0, z);
        }
        //上ボタンがが押されていないかつ、現在のX軸の角度が0より大きい時に傾きを0度に戻す処理
        if (vertical == 0&&currentXAngle>0)
        {
            //for(int i = 0; i < 5; i++)
            //{
            //    x += Time.deltaTime * p;
            //    p -= 5;

            //}

            if (bkc_count<1)
            {
                StartCoroutine("BackCurrent");
                
            }
            bkc_count++;

            if (currentXAngle > 0.1&&bkc_count>60)
            {
                x += Time.deltaTime * -30;//60f
            }
            //else
            //{
            //    x = 0;
            //}
            transform.rotation = Quaternion.Euler(x, 0, z);
        }
        else
        {
            bkc_count = 0;
        }


        //X軸の回転処理(下ボタン)
        if (vertical < 0)
        {
            if (currentXAngle > -30)
            {
                x += Time.deltaTime * -20;

            }
            else
            {
                x = -30;
            }
            transform.rotation = Quaternion.Euler(x, 0, z);
        }

        if (vertical == 0&&currentXAngle<0)
        {
            if (currentXAngle < -0.1)
            {
                x += Time.deltaTime * 30;
            }
            else
            {
                x = 0;
            }
            transform.rotation = Quaternion.Euler(x, 0, z);
        }

        //現在の角度が180より大きい場合
        if (currentZAngle > 180)
        {
            // デフォルトでは角度は0～360なので-180～180となるように補正
            currentZAngle = currentZAngle - 360;
        }

        //Z軸の回転処理(左ボタン）
        if (horizontal > 0)
        {
            if (currentZAngle < 30)
            {
                z += Time.deltaTime * 20;

            }
            else
            {
                z = 30;
            }
            transform.rotation = Quaternion.Euler(x, 0, z);
        }

        if (horizontal == 0 && currentZAngle > 0)
        {
            if (currentZAngle > 0.1)
            {
                z += Time.deltaTime * -30;
            }
            else
            {
                z = 0;
            }
            transform.rotation = Quaternion.Euler(x, 0, z);
        }

        //Z軸の回転処理(右ボタン）
        if (horizontal < 0)
        {
            if (currentZAngle > -30)
            {
                z += Time.deltaTime * -20f;

            }
            else
            {
                z = -30;
            }
            transform.rotation = Quaternion.Euler(x, 0, z);
        }

        if (horizontal == 0 && currentZAngle < 0)
        {
            if (currentZAngle < -0.1)
            {
                z += Time.deltaTime * 30;
            }
            else
            {
                z = 0;
            }
            transform.rotation = Quaternion.Euler(x, 0, z);
        }
    }
    IEnumerator BackCurrent()
    {
        float p = 20;

        //ここに処理を書く
        for (int i = 0; i < 60; i++)
        {
            
            x += Time.deltaTime * p;
            p = p-20f/60f;

            transform.rotation = Quaternion.Euler(x, 0, z);

            yield return null;
            Debug.Log(p);

        }

        //ここに再開後の処理を書く
    }
}
