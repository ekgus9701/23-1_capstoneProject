using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage1_4 : MonoBehaviour
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
        GeonLove=PlayerPrefs.GetFloat("GeonLove");
        
    }

    
  
   public void Load(){
     SceneManager.LoadScene("BeforeQuiz");
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
    yield return StartCoroutine(NormalChat("이건","음… 조금 더 같이 이야기하고 싶은데 일정이 있어서 가봐야겠다."));
    yield return StartCoroutine(NormalChat("이건","마을에서 즐거운 시간 보내고, 소설 쓰는 것도 응원할게."));
    yield return StartCoroutine(NormalChat(" 이건","그럼 먼저 가볼게. 또 보자!"));


    StartCoroutine(FadeCoroutine());
    Invoke("Load",3f);
    
  
 
    
   }

  
  
}


