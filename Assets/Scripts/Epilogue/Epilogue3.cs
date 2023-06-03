using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Epilogue3 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
    public Image image;
    public Image myTag;


    float textSpeed=0.03f;

    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());

    }
    

   public void Load(){
     SceneManager.LoadScene("BoyChoose");
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
    yield return StartCoroutine(NormalChat(me,"휴우, 이제 초고는 다 쓴 것 같은데…?"));
    yield return StartCoroutine(NormalChat(me,"아, 맞다. 남주 설정을 아직 다 완성 안 했었지."));
    yield return StartCoroutine(NormalChat(me,"음… 이번에 만났던 사람들 중에서 설정을 좀 따와도 괜찮을 것 같은데."));
    yield return StartCoroutine(NormalChat(me,"글도 잘 다듬어서 보여주면 그 사람도 좋아하지 않을까?"));
    yield return StartCoroutine(NormalChat(me,"…누구를 고르지?"));
    
    Load();
    
  
    
   }

  
  
}


