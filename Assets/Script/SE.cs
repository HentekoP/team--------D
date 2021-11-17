using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SE: MonoBehaviour
{
    private void Awake()
    {
       
    }
    // Use this for initialization
    void Start()
    {
        //Invoke("LoadScene", 3f);
        DontDestroyOnLoad(gameObject);
    }
    void LoadScene()
    {
        SceneManager.LoadScene("GameMain");
        SceneManager.LoadScene("Title");
        SceneManager.LoadScene("result");
    }
}