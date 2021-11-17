using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerpefs : MonoBehaviour
{
     //string coin_max;

    // Start is called before the first frame update
    void Start()
    {
        //int a;
        ToString();
        GetComponent<Text>().text = PlayerPrefs.GetInt("coin_max", 0).ToString();
        
        PlayerPrefs.GetInt("coin_max",0);
        // Debug.Log(PlayerPrefs.GetInt("coin_max", 0));
        //Debug.Log("coin_max");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
