using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleGo : MonoBehaviour
{
    public void replay()
    {
        // LoadSceneの引数にシーンの名前を入れて読み込む
        SceneManager.LoadScene("Title");
    }
}
