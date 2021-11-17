using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerprfs2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ToString();
        GetComponent<Text>().text = PlayerPrefs.GetFloat("time_max", 0).ToString("F2");

        PlayerPrefs.GetFloat("time_max");
     //   Debug.Log(PlayerPrefs.GetInt("time_max", 0).ToString("F2"));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
