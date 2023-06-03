using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Prologue2 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
   public Image image;

    float textSpeed=0.03f;
   
    
   

    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
        
    }

    

   void Load(){
     SceneManager.LoadScene("Stage1_1");
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

    IEnumerator FadeCoroutine(){
        float fadeCount=0;
        while(fadeCount<1.0f){
            fadeCount+=0.01f;
            yield return new WaitForSeconds(0.01f);
            image.color=new Color(0,0,0,fadeCount);
        }
    }
   IEnumerator TextPractice(){
    string str=PlayerPrefs.GetString("Name");
    yield return StartCoroutine(NormalChat("","…망했다."));
    yield return StartCoroutine(NormalChat("","며칠을 고민했는데도 괜찮은 소재가 안 떠올라."));
    yield return StartCoroutine(NormalChat("","안 되는데… 무조건 나 상 받아야 하는데…"));
    yield return StartCoroutine(NormalChat("","다른 작가님들은 막 여행 가서 아이디어 생각해 내고 그러던데. 나도 여행 가고 싶다…"));
    yield return StartCoroutine(NormalChat("","어, 맞다! 할머니!"));
    yield return StartCoroutine(NormalChat("","할머니 지금 여행 가서 집 비어 있다고 하지 않았나?"));
    yield return StartCoroutine(NormalChat("","거기 가서 혼자 산책도 하고 맛있는 것도 먹고 그러다 보면 왠지 영감이 떠오를 것 같은데~?"));
    yield return StartCoroutine(NormalChat("","그러다 잘생긴 애랑 썸도 탈 수도…"));
    yield return StartCoroutine(NormalChat("","…큼큼. 망상은 그만 하고. 어디 한 번 가볼까?"));
    StartCoroutine(FadeCoroutine());
	
    Invoke("Load",3f);
  
 
    
   }

  
  
}


