using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage1_2 : MonoBehaviour
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
      
      public void Pop1(){
        pop1.SetActive(true);
    }
      public void Pop2(){
        pop2.SetActive(true);
    }
      public void Pop3(){
        pop3.SetActive(true);
    }
    
   

    public string writerText="";
    void Start()
    {
       
        StartCoroutine(TextPractice());
        float GeonLove=PlayerPrefs.GetFloat("GeonLove");
        
    }

    

   public void Load1(){
     SceneManager.LoadScene("Stage1_2_1");
   }
    public void Load2(){
     SceneManager.LoadScene("Stage1_2_2");
   }
    public void Load3(){
     SceneManager.LoadScene("Stage1_2_3");
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
    yield return StartCoroutine(NormalChat("??","그런데 버스가 자주 오는 편은 아니라서 아마 걸어 가야 할 거예요."));
    yield return StartCoroutine(NormalChat("??","그나저나 이 집은 김씨 할머니 댁인데, 무슨 일로 가시는 건가요?"));
    boyTag.gameObject.SetActive(false);
    boyImage[0].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"아, 사실 제가 할머니 손녀예요."));
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("??","어? 그럼 너가 "+me+"? 그 소설 쓴다던?"));
    yield return StartCoroutine(NormalChat("??","아, 미안해요. 사실 할머니한테 얘기를 많이 들었어서 혼자 내적 친밀감을 갖고 있었나봐요."));
    yield return StartCoroutine(NormalChat(" 이건","생각해보니 제 소개도 안 했네요. 저는 이건이고 19살이에요."));
    boyTag.gameObject.SetActive(false);
    boyImage[1].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"아하하... 맞아요. 아, 그 말은 편하게 하셔도 돼요."));
    yield return StartCoroutine(NormalChat(me,"(아 진짜 할머니!! 사람들한테 TMI를 얼마나 많이 얘기하고 다닌 거야!)"));
    CharacterName.gameObject.SetActive(false);
    myTag.gameObject.SetActive(false);
    yield return StartCoroutine(NormalChat(me,"나는 이건에게 마을에 오게 된 사정을 얘기해주었다."));
    CharacterName.gameObject.SetActive(true);
    boyTag.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("이건","우와, 영감을 얻으려고 우리 마을에 오게 됐다고? 되게 멋지다."));
    yield return StartCoroutine(NormalChat("이건","할머니한테 너 얘기 들을 때마다 늘 궁금했어."));
    yield return StartCoroutine(NormalChat("이건","나도 소설 읽는 거 정말 좋아하거든. 혼자 있을 때 이런저런 생각하는 것도 좋아하고."));
     yield return StartCoroutine(NormalChat("이건","그래서 왠지 우리가 만나면 마치 소울메이트처럼 상응이 될 수 있을 것 같다는 느낌이 들었어."));

    boyImage[1].gameObject.SetActive(false);
    b1.SetActive(true);
    b2.SetActive(true);
    b3.SetActive(true);
    
  
 
    
   }

public void print(){
    Debug.Log("Click");
}
  
  
}


