using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage2_4 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
    
    public Image myTag;
    public Image boyTag;
    public GameObject[] boyImage;
    
    public Image fadeimage;
   

    float textSpeed=0.03f;
    float GeonLove;
    public string writerText="";
   
    IEnumerator FadeCoroutine(){
        float fadeCount=0;
        while(fadeCount<1.0f){
            fadeCount+=0.01f;
            yield return new WaitForSeconds(0.01f);
            fadeimage.color=new Color(0,0,0,fadeCount);
        }
    }
   
    
    void Start()
    {
        
        StartCoroutine(TextPractice());
       
        
    }

    
  
   public void Load(){
     SceneManager.LoadScene("BeforeQuiz2");
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
    CharacterName.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("윤이수","음, 이제 가봐야겠다. 나도 보기보다 바쁜 몸이라서."));
    yield return StartCoroutine(NormalChat("윤이수","공모전 준비 잘 하고. 나중에 또 보자고, 작가 선생님. 재밌었어."));


    StartCoroutine(FadeCoroutine());
    Invoke("Load",3f);
    
  
 
    
   }

  
  
}


