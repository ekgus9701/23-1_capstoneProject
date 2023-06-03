using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage1_3_2 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
   
    public Image myTag;
    public Image boyTag;
    public GameObject[] boyImage;
   
   
    float textSpeed=0.03f;
    float GeonLove;
    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
        GeonLove=PlayerPrefs.GetFloat("GeonLove");
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
    boyImage[3].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("이건","그렇지? 몇 년 전에 이장님께서 설치해주셨는데 정말 괜찮더라고."));
    GeonLove-=0;
    PlayerPrefs.SetFloat("GeonLove",GeonLove);
    float GeonHeart=PlayerPrefs.GetFloat("GeonLove");
    Debug.Log(GeonHeart);
    SceneManager.LoadScene("Stage1_4");
 
    
   }

  
  
}


