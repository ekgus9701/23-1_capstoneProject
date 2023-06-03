using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage3_2_1 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
   
    public Image myTag;
    public Image boyTag;
    public GameObject[] boyImage;
    float HJLove;
    
   
    //float GeonLove=PlayerPrefs.GetFloat("GeonLove");
    float textSpeed=0.03f;
    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
        HJLove=PlayerPrefs.GetFloat("HJLove");
        Debug.Log("현재"+HJLove);
        
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
    boyTag.gameObject.SetActive(true);
    boyImage[4].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("소현재","아니, 나도 그 뜻으로 말한 게 아닌데… "));
    HJLove-=10;
    PlayerPrefs.SetFloat("HJLove",HJLove);
    float HJ=PlayerPrefs.GetFloat("HJLove");
    Debug.Log(HJ);
    SceneManager.LoadScene("Stage3_3");
    
   
 
    
   }

  
  
}


