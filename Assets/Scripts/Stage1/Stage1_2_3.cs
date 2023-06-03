using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage1_2_3 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
   
    public Image myTag;
    public Image boyTag;
    public GameObject[] boyImage;
   
    float GeonLove;
    float textSpeed=0.03f;
    
    
   

    public string writerText="";
    void Start()
    {
        GeonLove=PlayerPrefs.GetFloat("GeonLove");
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
    boyImage[1].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("이건",me+"(이)도 그렇게 생각해? 역시 우리는 정말 잘 맞을 것 같다."));
    GeonLove+=10;
    PlayerPrefs.SetFloat("GeonLove",GeonLove);
    float GeonHeart=PlayerPrefs.GetFloat("GeonLove");
    Debug.Log(GeonHeart);
    SceneManager.LoadScene("Stage1_3");

   }

}


