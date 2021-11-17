using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public void OnClick()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
       yield return new WaitForSecondsRealtime(1.0f);

        Application.Quit();
    }
}