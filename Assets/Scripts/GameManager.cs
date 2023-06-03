using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ExitPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Time.timeScale=0f;

            ExitPanel.SetActive(true);
        }
    }

    public void ExitYes()  
    {
        Debug.Log("EXIT");
        #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
         #elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
         #else
         Application.Quit();
         #endif // 앱을 종료
    }
    public void ExitNo()
    {
        Time.timeScale = 1f; // 먼저 시간을 다시 가도록 원복 
        ExitPanel.SetActive(false); // Exit 팝업창을 지운다.
    }
}
