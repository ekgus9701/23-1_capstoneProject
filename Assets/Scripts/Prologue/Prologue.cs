using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Prologue : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
  

    float textSpeed=0.03f;
   
    

    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
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
    yield return StartCoroutine(NormalChat("","내 이름은 "+str+". 평범한 18살 고등학생이다."));
    yield return StartCoroutine(NormalChat("","사실 나에겐 꿈이 있는데..."));
    yield return StartCoroutine(NormalChat("","바로 로맨스 소설 작가가 되는 것!"));
    yield return StartCoroutine(NormalChat("","아직 고등학생이긴 하지만 틈틈이 포포타입에도 글도 올리면서 꿈을 이루기 위해 노력하고 있다."));
    yield return StartCoroutine(NormalChat("","조회수는 어떻냐고?"));
    yield return StartCoroutine(NormalChat("","..."));
    yield return StartCoroutine(NormalChat("","......"));
    yield return StartCoroutine(NormalChat("","…내 최애 작가님 글이나 보러 가야겠다."));
    yield return StartCoroutine(NormalChat("","어?"));
    SceneManager.LoadScene("Prologue1");
 
    
   }

  
  
}


