using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage3_2_3 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
   
    public Image myTag;
    public Image boyTag;
    public GameObject[] boyImage;
   
   float HJLove;
    
    float textSpeed=0.03f;
    
    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
        HJLove=PlayerPrefs.GetFloat("HJLove");
        Debug.Log("현재"+HJLove);
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
    boyImage[1].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("소현재","그래, 네가 아무 이유 없이 행동하는 애는 아니지. 그 이유가 대체 뭔데?"));
     HJLove+=10;
    PlayerPrefs.SetFloat("HJLove",HJLove);
    float HJ=PlayerPrefs.GetFloat("HJLove");
    Debug.Log(HJ);
    SceneManager.LoadScene("Stage3_3");
 
    
   }

  
  
}


