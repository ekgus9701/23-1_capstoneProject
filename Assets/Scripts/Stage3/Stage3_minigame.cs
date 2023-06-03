using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Stage3_minigame : MonoBehaviour
{

    public Text answerText; //사용자가 정답이라고 입력한 텍스트
    public string clickText;
    private string realAnswer="개괄";
    private string currentAnswer="";

    int stage3_score=0;
    int stage3_score_w=0;

   
    float HJLove; //바꿔야함

    public GameObject Correct;
    public GameObject Wrong;
    

    public Button[] menuButtonList;
    
    public void ButtonNoActive()
    {
        //모든버튼 비활성화​
        for (int temp = 0; temp < menuButtonList.Length; temp++)
            menuButtonList [temp].interactable = false;
        
        
    }
    
    void Start()
    {
         HJLove=PlayerPrefs.GetFloat("HJLove");
        Debug.Log("현재"+HJLove);
    }


    public void clickBtn(){
        // 방금 클릭한 게임 오브젝트를 가져와서 저장
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        

        // 방금 클릭한 게임 오브젝트의  버튼 속 문자 
        clickText=clickObject.GetComponentInChildren<Text>().text;
        currentAnswer+=clickText;
        answerText.text = currentAnswer;
        clickObject.SetActive(false);
    }

    // 단어 완성 확인 시 호출되는 함수
    public void CheckAnswer()
    {
        ButtonNoActive();
        
         
        if (currentAnswer == realAnswer)
        {
            PlayerPrefs.SetInt("stage3_score",0);
            PlayerPrefs.SetInt("stage3_score_w",0);

            stage3_score=PlayerPrefs.GetInt("stage3_score");
            Debug.Log("정답입니다!");
            stage3_score+=1;
            PlayerPrefs.SetInt("stage3_score",stage3_score);
            Debug.Log(stage3_score);
            
            HJLove+=5;
            PlayerPrefs.SetFloat("HJLove",HJLove);
            Correct.SetActive(true);
            Invoke("Load",1.5f);
            
        }
        else
        {
            Wrong.SetActive(true);
            HJLove-=5;
            PlayerPrefs.SetFloat("HJLove",HJLove);
            PlayerPrefs.SetInt("stage1_score",0);
            PlayerPrefs.SetInt("stage3_score_w",0);

            stage3_score_w=PlayerPrefs.GetInt("stage3_score_w");
                
            stage3_score_w+=1;
            PlayerPrefs.SetInt("stage3_score_w",stage3_score_w);
            Debug.Log(stage3_score_w);
            Debug.Log("오답");
            Invoke("Load",1.5f);
            
        }
    }

    private void Load(){
        
      SceneManager.LoadScene("Stage3_minigame2");
    }


}
