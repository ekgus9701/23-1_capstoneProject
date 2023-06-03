using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage3_3 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
    public Image image;
    public Image myTag;
    public Image boyTag;
   
    public GameObject[] boyImage;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject pop1;
    public GameObject pop2;
    public GameObject pop3;

    float textSpeed=0.03f;
    float HJLove=0f;
    
   

    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
        
        
    }
    public void Pop1(){
        pop1.SetActive(true);
    }
      public void Pop2(){
        pop2.SetActive(true);
    }
      public void Pop3(){
        pop3.SetActive(true);
    }
    

   public void Load1(){
     SceneManager.LoadScene("Stage3_3_1");
   }
    public void Load2(){
     SceneManager.LoadScene("Stage3_3_2");
   }
    public void Load3(){
     SceneManager.LoadScene("Stage3_3_3");
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
    yield return StartCoroutine(NormalChat(me,"…여기가 우리 할머니 집이 있는 곳이니까 마음이 편해."));
    yield return StartCoroutine(NormalChat(me,"그리고 이 마을에서 만난 사람들도 다 좋은 분들이고."));
    yield return StartCoroutine(NormalChat(me,"여기서 계속 지내면 마지막엔 정말로 좋은 글을 쓸 수 있을 것 같아."));
    boyTag.gameObject.SetActive(true);
    CharacterName.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("소현재","그래, "+me+" 네가 그렇다면야…"));
    yield return StartCoroutine(NormalChat("소현재","그래도 내가 여기 오니까 반갑지? 고맙지? 우웅?"));
    boyImage[1].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);


    yield return StartCoroutine(NormalChat(me,"으악! 왜 답지 않게 애교를 부려!"));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("소현재","음~ 사실 우리가 초딩 때 이후로 이렇게 떨어진 적이 처음이잖아."));
    yield return StartCoroutine(NormalChat("소현재","그래서 네가 없으니까 조금 심심하더라고."));
    yield return StartCoroutine(NormalChat("소현재","물론 다른 애들도 그렇게 말했고!!"));
    yield return StartCoroutine(NormalChat("소현재","근데 막 팥 없는 찐빵처럼 뭔가 결여돼있다는 느낌이 자꾸 들어."));
   

    boyImage[0].gameObject.SetActive(false);
  
    b1.SetActive(true);
    b2.SetActive(true);
    b3.SetActive(true);
    
   }

}


