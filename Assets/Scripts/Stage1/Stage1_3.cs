using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage1_3 : MonoBehaviour
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
   
    
   
    float GeonLove;
    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
        GeonLove=PlayerPrefs.GetFloat("GeonLove");
        
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
     SceneManager.LoadScene("Stage1_3_1");
   }
    public void Load2(){
     SceneManager.LoadScene("Stage1_3_2");
   }
    public void Load3(){
     SceneManager.LoadScene("Stage1_3_3");
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
    yield return StartCoroutine(NormalChat("이건","음, 이렇게 만난 기념으로 내가 글 쓰기 좋은 장소 추천해줄까?"));
    boyTag.gameObject.SetActive(false);
    boyImage[0].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);

    
    yield return StartCoroutine(NormalChat(me,"우와, 네! 너무 좋아요!"));
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("이건","저쪽에 산 보이지?"));
    yield return StartCoroutine(NormalChat("이건","조금만 올라가면 정자가 나오는데, 사람도 거의 안 오고 경치도 좋아서 혼자 힐링하기 딱이야."));
    yield return StartCoroutine(NormalChat(" 이건","산에 표지판도 잘 되어 있어서 길 찾기 어렵지 않고 용이할 거야."));
   

    boyImage[1].gameObject.SetActive(false);
    b1.SetActive(true);
    b2.SetActive(true);
    b3.SetActive(true);
    
  
 
    
   }

  
  
}


