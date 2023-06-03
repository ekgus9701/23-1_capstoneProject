using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Stage1_Slot3 : MonoBehaviour,IDropHandler
{
    public int id;
    float GeonLove;
    public GameObject CorrectTxt;
    public GameObject WrongTxt;
    int stage1_score;
    int stage1_score_w;
    
    void Start()
    {
        GeonLove=PlayerPrefs.GetFloat("GeonLove");
      
    }
    void load(){
        SceneManager.LoadScene("Stage1_minigame_result");
    }
   public void OnDrop(PointerEventData eventData){
        Debug.Log("OnDrop");
        if(eventData.pointerDrag!=null){
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=GetComponent<RectTransform>().anchoredPosition;
            if(eventData.pointerDrag.GetComponent<Stage1_Minigame>().id==id){

                stage1_score=PlayerPrefs.GetInt("stage1_score");
        stage1_score_w=PlayerPrefs.GetInt("stage1_score_w");


                GeonLove+=5;
                PlayerPrefs.SetFloat("GeonLove",GeonLove);
                stage1_score+=1;
                PlayerPrefs.SetInt("stage1_score",stage1_score);
                Debug.Log(stage1_score);
                //float GeonHeart=PlayerPrefs.GetFloat("GeonLove");
               // Debug.Log(GeonHeart);
                CorrectTxt.SetActive(true);
              //  int stage1=PlayerPrefs.GetInt("stage1_score");
              //  int stage_w1=PlayerPrefs.GetInt("stage1_score_w");

              //  Debug.Log(stage1+","+stage_w1);

                Invoke("load",1.5f);
            }

            else{

                stage1_score=PlayerPrefs.GetInt("stage1_score");
        stage1_score_w=PlayerPrefs.GetInt("stage1_score_w");

                GeonLove-=5;
                PlayerPrefs.SetFloat("GeonLove",GeonLove);

                stage1_score_w+=1;
                PlayerPrefs.SetInt("stage1_score_w",stage1_score_w);
                Debug.Log(stage1_score_w);

                //float GeonHeart=PlayerPrefs.GetFloat("GeonLove");
                //Debug.Log(GeonHeart);
                WrongTxt.SetActive(true);

             //   int stage1=PlayerPrefs.GetInt("stage1_score");
             //   int stage_w1=PlayerPrefs.GetInt("stage1_score_w");

            //    Debug.Log(stage1+","+stage_w1);

                Invoke("load",1.5f);
            }
            
        }
    }
}
