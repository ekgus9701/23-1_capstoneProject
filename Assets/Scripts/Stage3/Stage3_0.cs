using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage3_0 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
    public Image image;
    public Image myTag;


    float textSpeed=0.03f;
    float EsooLove=0f;
    
   

    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
        
        
        
    }
    

   public void Load(){
     SceneManager.LoadScene("Stage3_1");
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
    string me=PlayerPrefs.GetString("Name");
    CharacterName.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"어느덧 마을에 온 지도 일주일이 되어가네."));
    yield return StartCoroutine(NormalChat(me,"좋아, 오늘도 열심히 글 써보는 거야!"));
    yield return StartCoroutine(NormalChat(me,"그 전에 글 쓰면서 먹을 간식 좀 사러 가야지~"));
    
  
  

    Load();
    
  
    
   }

  
  
}


