using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    [SerializeField]
    [Tooltip("最小角度(-180～180")]
    private float MinAngle;

    [SerializeField]
    [Tooltip("最大角度(-180～180")]
    private float MaxAngle;

    [SerializeField]
    [Tooltip("回転するスピード")]
    private float rotationSpeed = -1;


    // Update is called once per frame
    void FixedUpdate()
    {
        // 左右キーの入力を取得
        float horizontal = Input.GetAxis("Horizontal")*-1;
        //上下キーの入力を取得
        float vertical = Input.GetAxis("Vertical");

        // 現在のGameObjectのZ軸方向の角度を取得
        float currentZAngle = transform.eulerAngles.z;
        //現在のGameObjectのX軸方向の角度を取得
        float currentXAngle = transform.eulerAngles.x;

        // 現在の角度が180より大きい場合
        if (currentZAngle > 180)
        {
            // デフォルトでは角度は0～360なので-180～180となるように補正
            currentZAngle = currentZAngle - 360;
        }
        // (現在の角度が最小角度以上かつキー入力が0未満(左キー押下)) または (現在の角度が最大角度以下かつキー入力が0より大きい(右キー押下))の時
        if ((currentZAngle >= MinAngle && horizontal < 0) || (currentZAngle <= MaxAngle && horizontal > 0))
        {
            // Z軸を基準に回転させる
            transform.Rotate(new Vector3(0, 0, horizontal * rotationSpeed));
        }

        //現在の角度が最小角度以上かつ0未満かつキー入力がない時
        if (currentZAngle >= MinAngle-1 &&currentZAngle<0&& horizontal == 0)
        {
            transform.Rotate(new Vector3(0, 0,0.4f*rotationSpeed));
            if (currentZAngle >-0.5)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0));
                currentZAngle = 0;
            }

        }
        //現在の角度が最大角度以上かつ0より大きいかつキー入力がない時
        if (currentZAngle <= MaxAngle+1 && currentZAngle > 0 && horizontal == 0)
        {
            transform.Rotate(new Vector3(0, 0, -0.4f * rotationSpeed));
            if (currentZAngle <0.5)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0));
                currentZAngle = 0;
            }
        }

        //現在の角度が180より大きい場合
        if (currentXAngle > 180)
        {
            // デフォルトでは角度は0～360なので-180～180となるように補正
            currentXAngle = currentXAngle - 360;
        }
        // (現在の角度が最小角度以上かつキー入力が0未満(左キー押下)) または (現在の角度が最大角度以下かつキー入力が0より大きい(右キー押下))の時
        if ((currentXAngle >= MinAngle && vertical < 0) || (currentXAngle <= MaxAngle && vertical > 0))
        {
       
            // X軸を基準に回転させる
            transform.Rotate(new Vector3(vertical * rotationSpeed, 0, 0));
        }

        if (currentXAngle >= MinAngle - 1 && currentXAngle < 0 && vertical == 0)
        {
            transform.Rotate(new Vector3(0.4f * rotationSpeed,0,0));
            if (currentXAngle >-0.5)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0, transform.eulerAngles.y, transform.eulerAngles.z));
                currentXAngle = 0;
            }
        }
        if (currentXAngle <= MaxAngle + 1 && currentXAngle > 0 && vertical == 0)
        {
            transform.Rotate(new Vector3(-0.4f * rotationSpeed, 0, 0));
            if (currentXAngle <0.5)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0, transform.eulerAngles.y, transform.eulerAngles.z));
                currentXAngle = 0;
            }
        }
       
    }
}
