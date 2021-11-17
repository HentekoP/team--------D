using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//このスクリプトはコイン取得数を表示するテキストにつける
//最大コイン数の定義がCoinPlaceで習得はここからというねじれた感じになってしまった……
public class CoinCount : MonoBehaviour
{
    [SerializeField] private GameObject coin_place_obj;//コイン配置スクリプトが置いてあるオブジェクトを入れる
    private int coin_max;//最大コイン数、ここの値はcoin_placeの子オブジェクトをカウントしただけなので配置数を変える場合CoinPlaceスクリプトのPLACEを変更するとよし
    private int coin_count;//現在残りコイン数
    private string st;//"取得数 / 最大数" の"/ 最大数"の部分

    //ステージを増やすとその数だけPLACEを設ける必要があるため最大数の取得は子オブジェクト数のカウントが一番いいと踏んだ
    //CoinPlaceはステージによって配置の形も変わりそうなので1本化しようと考えたがそれも難しそう


    // Start is called before the first frame update
    void Start()
    {
        coin_max= coin_place_obj.transform.childCount;
        coin_count = coin_max;
        PlayerPrefs.SetInt("coin_max",coin_max);//今回のステージのコイン最大数を保存

        st = "/" + coin_max;
        GetComponent<Text>().text = (coin_max - coin_count) + st;
    }

    // Update is called once per frame
    void Update()
    {
        if(coin_count!= coin_place_obj.transform.childCount)//coin_place_objの子オブジェクトの数と前回までの配置コイン記録変数が違う場合値を更新
        {
            coin_count = coin_place_obj.transform.childCount;
            GetComponent<Text>().text = (coin_max - coin_count)+ st;//最大値から現在の子オブジェクト数を引いた値が現在の取得コイン数になる
        }
    }
}
