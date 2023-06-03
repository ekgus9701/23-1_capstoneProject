using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage2_3 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
    public Image image;
    public Image myTag;
    public Image boyTag;
    
    public GameObject[] boyImage;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject pop1;
    public GameObject pop2;
    public GameObject pop3;

    float textSpeed=0.03f;
    float EsooLove=0f;
    
   

    public string writerText="";
    void Start()
    {
        
        StartCoroutine(TextPractice());
        
        
    }
    public void Pop1(){
        pop1.SetActive(true);
    }
      public void Pop2(){
        pop2.SetActive(true);
    }
      public void Pop3(){
        pop3.SetActive(true);
    }
    

   public void Load1(){
     SceneManager.LoadScene("Stage2_3_1");
   }
    public void Load2(){
     SceneManager.LoadScene("Stage2_3_2");
   }
    public void Load3(){
     SceneManager.LoadScene("Stage2_3_3");
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
   
    
    myTag.gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat(me,"아무튼 고마워. 마음이 한결 편해진 것 같아."));
    
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("윤이수","그러냐? 그럼 다행이고."));
    yield return StartCoroutine(NormalChat("윤이수","아, 혹시 네 글 쓴 거 있으면 보여주면 안 되냐?"));
    yield return StartCoroutine(NormalChat("윤이수","그냥 궁금해서 그런 거니까 부담스러우면 안 보여줘도 돼."));

    boyImage[0].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"음… 그럼 내 노트 볼래?"));
    

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);

     yield return StartCoroutine(NormalChat("윤이수","진짜? 내가 봐도 되는 건가?"));

     boyImage[0].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"안 될 것 없지. 너 덕분에 기분도 나아졌으니까 보답으로 보여줄게."));
    
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("윤이수","오... 뭔지는 모르겠지만 재밌는데?"));
    yield return StartCoroutine(NormalChat("윤이수","그, 요즘 웹툰 생각나기도 하고."));

    boyImage[1].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat(me,"정말? 다행이다."));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);

     yield return StartCoroutine(NormalChat("윤이수","그래. 아까도 말했지만 너, 네 생각보다 능력 있는 애야."));
     yield return StartCoroutine(NormalChat("윤이수","벌써부터 그렇게 안 될 거라고 간주하고 기죽지 말라고. 차라리 1등은 네가 먹었다고 여겨봐. 크큭."));

    boyImage[1].gameObject.SetActive(false);
    b1.SetActive(true);
    b2.SetActive(true);
    b3.SetActive(true);
    
  
 
    
   }

  
  
}


