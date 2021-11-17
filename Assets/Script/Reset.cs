using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Reset : MonoBehaviour
{
   
    public void replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameMain");
    }

// Update is called once per frame
void Update()
    {
        //Time.timeScale = 1f;
    }
}
