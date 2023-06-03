using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage2_2_2 : MonoBehaviour
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
    boyImage[4].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("윤이수","뭐? 노트 뒤? 그게 무슨 상관인데?"));
    EsooLove-=10;
    PlayerPrefs.SetFloat("EsooLove",EsooLove);
    float Esoo=PlayerPrefs.GetFloat("EsooLove");
    Debug.Log(Esoo);
    SceneManager.LoadScene("Stage2_3");

   }

}


