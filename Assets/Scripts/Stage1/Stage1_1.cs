using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage1_1 : MonoBehaviour
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
    float GeonLove=0f;
    
   

    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
        PlayerPrefs.SetFloat("GeonLove",GeonLove);
        
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
     SceneManager.LoadScene("Stage1_1_1");
   }
    public void Load2(){
     SceneManager.LoadScene("Stage1_1_2");
   }
    public void Load3(){
     SceneManager.LoadScene("Stage1_1_3");
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
    yield return StartCoroutine(NormalChat(me,"드디어 도착했다!"));
    yield return StartCoroutine(NormalChat(me,"그런데 할머니 집은 어떻게 가더라? 오랜만에 와서 기억이 하나도 안 나네."));
    myTag.gameObject.SetActive(false);
    CharacterName.gameObject.SetActive(false);
    yield return StartCoroutine(NormalChat("","그렇게 두리번거리던 나에게 누군가 다가왔다"));
    boyTag.gameObject.SetActive(true);
    CharacterName.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("??","혹시 뭐 찾으시나요?"));
    boyImage[0].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"헉...!"));
    yield return StartCoroutine(NormalChat(me,"(와... 얼굴 대박이네...)"));
    yield return StartCoroutine(NormalChat(me,"크흠… 혹시 이 집 어디 있는지 아세요?"));
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("??","음, 마을 회관 근처에 있는 집이네요."));
    yield return StartCoroutine(NormalChat("??","30분에서 40분정도 걸으면 될 거예요."));
    yield return StartCoroutine(NormalChat("??","버스 타면 10분 내지 15분만에 갈 수 있긴 해요."));
    boyImage[0].gameObject.SetActive(false);
    b1.SetActive(true);
    b2.SetActive(true);
    b3.SetActive(true);
    
  
 
    
   }

  
  
}


