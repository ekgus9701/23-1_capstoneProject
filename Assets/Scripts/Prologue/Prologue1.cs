using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Prologue1 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
    public GameObject Appear;
     public Image image;


    float textSpeed=0.03f;
   
    

    public string writerText="";
    void Start()
    {
            Invoke("AppearChat",1.5f);
            
       
        
    }
     void Load(){
     SceneManager.LoadScene("Prologue2");
   }
    void AppearChat(){
        Appear.SetActive(true);
        StartCoroutine(TextPractice());
    }

   IEnumerator FadeCoroutine(){
        float fadeCount=0;
        while(fadeCount<1.0f){
            fadeCount+=0.01f;
            yield return new WaitForSeconds(0.01f);
            image.color=new Color(0,0,0,fadeCount);
        }
    }

   IEnumerator NormalChat(string narrator,string narration){
    int a=0;
    CharacterName.text=narrator;
    writerText="";

    for(a=0;a<narration.Length;a++){
        writerText+=narration[a];
        ChatText.text=writerText;
        yield return new WaitForSeconds(textSpeed);
    }

    while(true){
        
        if(Input.GetMouseButtonDown(0)){
            break;
        }
        yield return null;

    }
   }

   IEnumerator TextPractice(){
    string str=PlayerPrefs.GetString("Name");
    yield return StartCoroutine(NormalChat("","로맨스 소설 공모전...?"));
    yield return StartCoroutine(NormalChat("","심지어 1등하면 상금도 주고 한 달 내내 포포타입에서 홍보도 해준다고??!!"));
    yield return StartCoroutine(NormalChat("","이건 날 위한 공모전이야. 1등 무조건 한다! 가보자고!!"));
    StartCoroutine(FadeCoroutine());
    Invoke("Load",3f);
    
 
    
   }

  
  
}


