using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage2_1_1 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
   
    public Image myTag;
    public Image boyTag;
    public GameObject[] boyImage;
    
   
    //float GeonLove=PlayerPrefs.GetFloat("GeonLove");
    float textSpeed=0.03f;
    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
        
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
    yield return StartCoroutine(NormalChat("윤이수","뭐? 설마 쫓아내기까지 하겠냐? 큭큭."));
    SceneManager.LoadScene("Stage2_2");
    
   
 
    
   }

  
  
}


