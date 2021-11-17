using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//現在は不要という事で最初から床に傾きがあった場合配置が床に接地しない、必要があれば初期角度による配置も追記する
public class CoinPlaceStage1 : MonoBehaviour
{
    [SerializeField] private GameObject panel;//床
    [SerializeField] private GameObject coin;//配置アイテム
    [SerializeField] private float radius;//円形配置らしいから円半径

    private const int PLACE=12;//配置数

    //float a=PLACE*Mathf.PI;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < PLACE; i++)
        {
            float angle = 360 / PLACE * i * Mathf.Deg2Rad;
            GameObject obj = Instantiate(coin);
            obj.transform.position = new Vector3(radius * Mathf.Cos(angle), obj.transform.localScale.y, radius * Mathf.Sin(angle));
            obj.transform.Rotate(345,320,54);
            obj.transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = panel.transform.rotation;
    }
}
