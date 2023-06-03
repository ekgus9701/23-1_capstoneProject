using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage2_3_2 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
   
    public Image myTag;
    public Image boyTag;
    public GameObject[] boyImage;
   float EsooLove;
    
    float textSpeed=0.03f;
    
    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
        EsooLove=PlayerPrefs.GetFloat("EsooLove");
         Debug.Log("cjdma"+EsooLove);
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
    yield return StartCoroutine(NormalChat("윤이수","그럼 다행이고. 파이팅 넘치는 모습 보기 좋네. 키킥."));
    EsooLove+=10;
    PlayerPrefs.SetFloat("EsooLove",EsooLove);
    //float EsooLove=PlayerPrefs.GetFloat("EsooLove");
    Debug.Log(EsooLove);
    SceneManager.LoadScene("Stage2_4");
 
    
   }

  
  
}


