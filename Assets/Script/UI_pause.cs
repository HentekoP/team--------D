

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UI_pause : MonoBehaviour

{
    private
    int i;
    public RectTransform Menubur;
    int Menu_Num = 0;
    bool Push_flag = false;
    int Event;
    private bool inGame;


    [SerializeField]
    private GameObject EventSystems;

    //　ポーズした時に表示するUI
    [SerializeField]
    private GameObject pauseUI;


    public object Button1 { get; private set; }

   // private void Start() {  }

    void Start()
    {
        pauseUI.SetActive(false);
        Invoke("Update", 4);
    }
    // Update is called once per frame
  

    void Update()
    {
        
        if (Input.GetKeyDown("joystick button 7"))

        {

            pauseUI.SetActive(!pauseUI.activeSelf);
            i = (i + 1) % 2;
            if (pauseUI.activeSelf) { Time.timeScale = 0f; }
            else { Time.timeScale = 1f; }
        }

       

        if (i == 1)
        {
            //　ポーズUIのアクティブ、非アクティブを切り替え
            if (Input.GetKey(KeyCode.Alpha1)) { SceneManager.LoadScene(SceneManager.GetActiveScene().name); }
        }

        //if (lsv == 1)
        //{
        //    if (Push_flag == false)
        //    {
        //        Push_flag = true;
        //        Menu_Num++;

        //        if (Menu_Num >= 3)

        //        {
        //            Menu_Num = 0;
        //            Menubur.position += new Vector3(0, 180, 0);
        //        }
        //        Menubur.position += new Vector3(0, -60, 0);
        //    }

        //}
        //else if (lsv == -1)
        //{
        //    if (Push_flag == false)
        //    {
        //        Push_flag = true;
        //        Menu_Num--;
        //        if (Menu_Num <= -1)
        //        {
        //            Menu_Num = 2;
        //            Menubur.position += new Vector3(0, -180, 0);
        //        }
        //        Menubur.position += new Vector3(0, 60, 0);
        //    }
        //}
        
    }
  
}



