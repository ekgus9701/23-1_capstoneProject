using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage3_4 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
    public Image image;
    public Image myTag;
    public Image boyTag;

    public Image fadeimage;
   
    public GameObject[] boyImage;
    

    float textSpeed=0.03f;
    float HJLove=0f;
    
   IEnumerator FadeCoroutine(){
        float fadeCount=0;
        while(fadeCount<1.0f){
            fadeCount+=0.01f;
            yield return new WaitForSeconds(0.01f);
            fadeimage.color=new Color(0,0,0,fadeCount);
        }
    }

    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
        
        
    }
   

   public void Load(){
     SceneManager.LoadScene("BeforeQuiz3");
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
    
    
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("소현재","에이, 됐다. 그래도 이렇게 얼굴 보니까 좋네."));
    yield return StartCoroutine(NormalChat("소현재","그럼 어디 "+me+"(이)가 자주 가는 맛집 먼저 가볼까?"));
    
    boyImage[1].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat(me,"으이그! 알았어. 가자, 가!"));

    StartCoroutine(FadeCoroutine());
    Invoke("Load",3f);
    
    
   }

}


