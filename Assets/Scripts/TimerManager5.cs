using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TimerManager5 : MonoBehaviour
{
    
    public Text[] text_time; // 시간을 표시할 text
    public GameObject TimeEnd;
    float time=10; // 시간.
      public Button[] menuButtonList;
    
       public void ButtonNoActive()
    {
        //모든버튼 비활성화​
        for (int temp = 0; temp < menuButtonList.Length; temp++)
            menuButtonList [temp].interactable = false;
        
        
    }

    private void Load()
    {
       SceneManager.LoadScene("Stage2_Minigame_OX3");
    }
    
    private void Update() // 바뀌는 시간을 text에 반영 해 줄 update 생명주기
    {
        
           time -= Time.deltaTime;
           
            text_time[0].text = ((int)time % 60 ).ToString()+"초";
            if(time<=1){
                ButtonNoActive();
                TimeEnd.SetActive(true);
                ButtonNoActive();
                text_time[0].text="0초";
                Invoke("Load",1.5f);
            }
    }
}