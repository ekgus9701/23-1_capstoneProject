using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Epilogue : MonoBehaviour
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
     SceneManager.LoadScene("Epilogue2_1");
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
    yield return StartCoroutine(NormalChat(me,"끄응, 이제 공모전 마감이… 3일 남았네…?"));
    yield return StartCoroutine(NormalChat(me,"벌써 시간이 이렇게 됐나…?!"));
    yield return StartCoroutine(NormalChat(me,"…그래도 시골로 내려오길 잘 한 것 같아."));
    yield return StartCoroutine(NormalChat(me,"좋은 사람들도 많이 만났고, 재밌는 일들도 많았지."));
    yield return StartCoroutine(NormalChat(me,"좋아! 할 수 있을 것 같아. 어디 한 번 써보자!"));
    
    Load();
    
  
    
   }

  
  
}


