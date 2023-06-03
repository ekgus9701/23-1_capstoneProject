using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chat1 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;

    public GameObject b1;
    public GameObject b2;
    public GameObject Disappear;

    //public Button nextBtn;
    
    public GameObject img,img2;

    float textSpeed=0.03f;
    float catLove=0f;
    

    public string writerText="";
    void Start()
    {
        b1.SetActive(false);
        b2.SetActive(false);
        StartCoroutine(TextPractice());
    }

    public void B1(){
        catLove+=1;
       
        PlayerPrefs.SetFloat("catHeart",catLove); //고양이 호감도에 저장
        float catHeart=PlayerPrefs.GetFloat("catHeart"); //불러옴
       // SceneManager.LoadScene("Game Scene1");

        Debug.Log("고양이 호감도: "+catHeart);
    }

    public void B2(){
        catLove--;
        
        PlayerPrefs.SetFloat("catHeart",catLove); //고양이 호감도에 저장
        float catHeart=PlayerPrefs.GetFloat("catHeart"); //불러옴
       // SceneManager.LoadScene("Game Scene1");

        Debug.Log("고양이 호감도: "+catHeart);
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
    string str=PlayerPrefs.GetString("Name");
    yield return StartCoroutine(NormalChat(str,"안녕 나는 주인공"));
    yield return StartCoroutine(NormalChat(str,"내 이름은 "+str+"(이)야"));
    //img.SetActive(false);
    img2.SetActive(true);
    yield return StartCoroutine(NormalChat("고양이","나는 조연"));
    yield return StartCoroutine(NormalChat("고양이","생선이 좋아"));
    b1.SetActive(true);
    b2.SetActive(true);
    Disappear.SetActive(false);
 
    
   }

  
  
}


