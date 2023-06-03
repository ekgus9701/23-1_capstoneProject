using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Stage1_Slot : MonoBehaviour,IDropHandler
{
    public int id;
    float GeonLove;
    public GameObject CorrectTxt;
    public GameObject WrongTxt;
    int stage1_score=0;
    int stage1_score_w=0; //틀린개수
    
    
    void Start()
    {
        GeonLove=PlayerPrefs.GetFloat("GeonLove");
    }
    void load(){
        SceneManager.LoadScene("Stage1_Minigame2");
    }
   public void OnDrop(PointerEventData eventData){
        Debug.Log("OnDrop");
        
        if(eventData.pointerDrag!=null){
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=GetComponent<RectTransform>().anchoredPosition;
            if(eventData.pointerDrag.GetComponent<Stage1_Minigame>().id==id){
                PlayerPrefs.SetInt("stage1_score",0);
                PlayerPrefs.SetInt("stage1_score_w",0);

                stage1_score=PlayerPrefs.GetInt("stage1_score");
         
                GeonLove+=5;
                PlayerPrefs.SetFloat("GeonLove",GeonLove);
                stage1_score+=1;
                PlayerPrefs.SetInt("stage1_score",stage1_score);
                Debug.Log(stage1_score);

                //float GeonHeart=PlayerPrefs.GetFloat("GeonLove");
                //Debug.Log(GeonHeart);
                CorrectTxt.SetActive(true);

               // int stage1=PlayerPrefs.GetInt("stage1_score");
               // int stage_w1=PlayerPrefs.GetInt("stage1_score_w");

                //Debug.Log(stage1+","+stage_w1);

                Invoke("load",1.5f);
            }

            else{
                PlayerPrefs.SetInt("stage1_score",0);
                PlayerPrefs.SetInt("stage1_score_w",0);

                stage1_score_w=PlayerPrefs.GetInt("stage1_score_w");
                GeonLove-=5;
                PlayerPrefs.SetFloat("GeonLove",GeonLove);
                stage1_score_w+=1;
                PlayerPrefs.SetInt("stage1_score_w",stage1_score_w);
                Debug.Log(stage1_score_w);
                //float GeonHeart=PlayerPrefs.GetFloat("GeonLove");
                //Debug.Log(GeonHeart);
                WrongTxt.SetActive(true);

                /*int stage1=PlayerPrefs.GetInt("stage1_score");
                int stage_w1=PlayerPrefs.GetInt("stage1_score_w");

                Debug.Log(stage1+","+stage_w1);*/

                Invoke("load",1.5f);
            }
            
        }
    }
}
