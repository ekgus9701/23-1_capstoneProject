using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Minigame_OX : MonoBehaviour
{
     //문제1
    public GameObject Correct1;
    public GameObject Wrong1;

    //문제2
    public GameObject Correct2;
    public GameObject Wrong2;

    //문제3
    public GameObject Correct3;
    public GameObject Wrong3;

    



    int stage2_score=0; //맞힌 개수
    int stage2_score_w=0; //틀린개수


    
    float EsooLove; //바꿔야함
    public Button[] menuButtonList;

    public void ButtonNoActive()
    {
        //모든버튼 비활성화​
        for (int temp = 0; temp < menuButtonList.Length; temp++)
            menuButtonList [temp].interactable = false;
        
        
    }
    
    void Start()
    {
        EsooLove=PlayerPrefs.GetFloat("EsooLove");
         //Debug.Log(stage2_score+","+stage2_score_w);
        
        
    }

    //문제1
    public void CorrectClick1(){
        PlayerPrefs.SetInt("stage2_score",0);
         PlayerPrefs.SetInt("stage2_score_w",0);
         stage2_score=PlayerPrefs.GetInt("stage2_score");
        Correct1.SetActive(true);
       
        ButtonNoActive();
        EsooLove+=5;
        PlayerPrefs.SetFloat("EsooLove",EsooLove);
        //float GeonHeart=PlayerPrefs.GetFloat("GeonLove");
        //Debug.Log(GeonHeart);
        stage2_score++;
        PlayerPrefs.SetInt("stage2_score",stage2_score);
        Debug.Log(stage2_score+","+stage2_score_w);
        
        
        
        Invoke("Load",1f);
    }

     public void WrongClick1(){
         PlayerPrefs.SetInt("stage2_score",0);
         PlayerPrefs.SetInt("stage2_score_w",0);
         stage2_score=PlayerPrefs.GetInt("stage2_score_w");
        ButtonNoActive();
        Wrong1.SetActive(true);
        EsooLove-=5;
        PlayerPrefs.SetFloat("EsooLove",EsooLove);
        stage2_score_w++;
       PlayerPrefs.SetInt("stage2_score_w",stage2_score_w);
       Debug.Log(stage2_score+","+stage2_score_w);
        
        //float GeonHeart=PlayerPrefs.GetFloat("GeonLove");
        //Debug.Log(GeonHeart);
        Invoke("Load",1.5f);
        
    }

    private void Load(){
        
      SceneManager.LoadScene("Stage2_Minigame_OX2");
    }

    //문제2
    public void CorrectClick2(){
         stage2_score=PlayerPrefs.GetInt("stage2_score");
        Correct2.SetActive(true);
       
        ButtonNoActive();
        EsooLove+=5;
        PlayerPrefs.SetFloat("EsooLove",EsooLove);
        //float GeonHeart=PlayerPrefs.GetFloat("GeonLove");
        //Debug.Log(GeonHeart);
        stage2_score++;
        PlayerPrefs.SetInt("stage2_score",stage2_score);
        Debug.Log(stage2_score+","+stage2_score_w);
        
        
        Invoke("Load2",1.5f);
    }

     public void WrongClick2(){
        stage2_score_w=PlayerPrefs.GetInt("stage2_score_w");
        ButtonNoActive();
        Wrong2.SetActive(true);
        EsooLove-=5;
        PlayerPrefs.SetFloat("EsooLove",EsooLove);
       stage2_score_w++;
        PlayerPrefs.SetInt("stage2_score_w",stage2_score_w);
        Debug.Log(stage2_score+","+stage2_score_w);
        
        //float GeonHeart=PlayerPrefs.GetFloat("GeonLove");
        //Debug.Log(GeonHeart);
        Invoke("Load2",1.5f);
        
    }

    private void Load2(){
        
      SceneManager.LoadScene("Stage2_Minigame_OX3");
    }

    //문제3
    public void CorrectClick3(){
        stage2_score=PlayerPrefs.GetInt("stage2_score");
        Correct3.SetActive(true);
       
        ButtonNoActive();
        EsooLove+=5;
        PlayerPrefs.SetFloat("EsooLove",EsooLove);
        //float GeonHeart=PlayerPrefs.GetFloat("GeonLove");
        //Debug.Log(GeonHeart);
        stage2_score++;
        PlayerPrefs.SetInt("stage2_score",stage2_score);
        Debug.Log(stage2_score+","+stage2_score_w);
        int stage2=PlayerPrefs.GetInt("stage2_score");
        int stage_w2=PlayerPrefs.GetInt("stage2_score_w");

        Debug.Log(stage2+","+stage_w2);
        
        Invoke("Load3",1.5f);
    }

     public void WrongClick3(){
        stage2_score_w=PlayerPrefs.GetInt("stage2_score_w");
        ButtonNoActive();
        Wrong3.SetActive(true);
        EsooLove-=5;
        PlayerPrefs.SetFloat("EsooLove",EsooLove);
       stage2_score_w++;
        PlayerPrefs.SetInt("stage2_score_w",stage2_score_w);
        int stage2=PlayerPrefs.GetInt("stage2_score");
        int stage_w2=PlayerPrefs.GetInt("stage2_score_w");

        Debug.Log(stage2+","+stage_w2);
        
        //float GeonHeart=PlayerPrefs.GetFloat("GeonLove");
        //Debug.Log(GeonHeart);
        
        Invoke("Load3",1.5f);
        
    }

    private void Load3(){
        
      SceneManager.LoadScene("Stage2_minigame_result");
    }



  

}
