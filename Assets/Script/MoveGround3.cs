using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround3 : MonoBehaviour
{
    [SerializeField] private int move = 30;//動きの最大値

    [SerializeField] private float accel = 90;//0から最大値までの時間
    [SerializeField] private float back = 60;//最大値から戻るまでの時間

    float[] xv = { 90, 0 };//x角度 vertical入力状況
    float[] zh = { 90, 0 };//z角度 horizontal入力状況
    //x,zは0から180のmoveに掛ける為の値が入れられている

    bool[] use_flg_xz = { false, false };//x,zの入力コルーチン使用フラグ、こういうのが出るのは構造がおかしいかもしれないが
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 左右キーの入力を取得
        zh[1] = Input.GetAxis("Horizontal");
        //上下キーの入力を取得
        xv[1] = Input.GetAxis("Vertical")*-1;

        if (!use_flg_xz[0] && xv[1] != 0) { StartCoroutine(PushMove(xv, 0)); }
        if (!use_flg_xz[1] && zh[1] != 0) { StartCoroutine(PushMove(zh, 1)); }

        transform.rotation = Quaternion.Euler(move * Mathf.Cos(xv[0] * Mathf.Deg2Rad), 0, move * Mathf.Cos(zh[0] * Mathf.Deg2Rad));
    }

    IEnumerator PushMove(float[] val,int xz)//xzはこのコルーチンがxを変更するのかzを変更するのか入れる、フラグ管理に必要
    {
        if (xz == 0) { use_flg_xz[0] = true; }//フラグのオンオフ
        else { use_flg_xz[1] = true; }

        float code = val[1] > 0 ? 1 : -1;//+側か-側かどちらに動いていたか
        float add = 90 / accel;
        while (val[1] != 0)//入力が切れたら終わり
        {
            if (val[1]>0)
            {
                if (val[0] < 180) { val[0] += add; }
                else { val[0] = 180; }//キッチリ180にならない可能性があるのでelseで180を入れる
            }
            else//マイナス方向
            {
                if (val[0] > 0) { val[0] -= add; }
                else { val[0] = 0; }
            }
            yield return null;
        }

        if (xz==0) { use_flg_xz[0] = false; }//フラグのオンオフ
        else { use_flg_xz[1] = false; }

        for (int i = 0; i < back; i++)//減速処理
        {
            if (val[1] != 0|| val[0]>=180 || val[0]<=0) { break; }//入力があった場合若しくは角度サイズが大小問わず30以上になった時点で終了
            add -= (90 / accel) / back;
            val[0] += add * code;
            yield return null;
        }
        StartCoroutine(BackMove(val));
    }
    IEnumerator BackMove(float[] val)//元に戻す処理
    {
        float code = val[0]>90 ? -1 : 1 ;
        float add = 90 / back * code;

        while (val[1] == 0)//入力があったらやめる
        {
            val[0] += add;
            if (code > 0 && val[0] >= 90) { val[0] = 90; break; }
            if (code < 0 && val[0] <= 90) { val[0] = 90; break; }

            yield return null;
        }
    }
}
