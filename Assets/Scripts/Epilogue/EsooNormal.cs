using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EsooNormal : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
   
    public Image myTag;
    public Image boyTag;
    public GameObject[] boyImage;

     public Image fadeimage;
     public GameObject whiteImage;

     private Image image1;
     public Sprite image2;
     public Sprite image3;
     public Sprite image4;

     
    
   
    //float GeonLove=PlayerPrefs.GetFloat("GeonLove");
    float textSpeed=0.03f;
    public string writerText="";

       IEnumerator FadeCoroutine(){
        float fadeCount=0;
        while(fadeCount<1.0f){
            fadeCount+=0.01f;
            yield return new WaitForSeconds(0.01f);
            fadeimage.color=new Color(0,0,0,fadeCount);
        }
    }


    void Start()
    {
        
        StartCoroutine(TextPractice());
        image1=GameObject.Find("Canvas1").GetComponent<Image>();
        
    }

     public void Load(){
     SceneManager.LoadScene("End1");
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
     yield return StartCoroutine(NormalChat(me,"벌써 떠날 시간이구나."));
    yield return StartCoroutine(NormalChat(me,"이렇게 가기 아쉬운데…"));
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    
   
    yield return StartCoroutine(NormalChat("??",me+"?"));
    boyTag.gameObject.SetActive(false);
    
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"헉, 깜짝이야!"));
    yield return StartCoroutine(NormalChat(me,"윤이수?"));
    
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("윤이수","뭐야, "+me+" 맞네."));
    yield return StartCoroutine(NormalChat("윤이수","이제 떠나는 거냐?"));

    boyTag.gameObject.SetActive(false);
     boyImage[1].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"응, 공모전도 끝났거든."));
    yield return StartCoroutine(NormalChat(me,"아, 혹시 내 소설 읽어볼래?"));
    yield return StartCoroutine(NormalChat(me,"사실 이 소설, 너 생각하면서 쓴 거야."));

   myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("윤이수","뭐? 나를? 지금 읽어봐도 되는 거냐?"));
    yield return StartCoroutine(NormalChat("윤이수","…"));

    boyImage[0].gameObject.SetActive(false);
    boyImage[3].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("윤이수","오, 나쁘지 않네."));

    boyTag.gameObject.SetActive(false);
    boyImage[3].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"진짜? 다행이다!"));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[3].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("윤이수","응. 재밌어. 게다가 너 어휘력도 꽤 좋네?"));
    yield return StartCoroutine(NormalChat("윤이수","또… 나랑 있었던 일로 이렇게 소설까지 써줬다니까 좀 기분이 이상하네."));
    yield return StartCoroutine(NormalChat("윤이수","크흠, 너 서울 가도 가끔 연락해도 되냐?"));

    boyTag.gameObject.SetActive(false);
    boyImage[3].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"…! 응, 당연하지! 고마워!"));
     

    image1.sprite = image2;
    myTag.gameObject.SetActive(false);
    yield return StartCoroutine(NormalChat("","시간은 빠르게 흘러 어느덧 공모전 결과 발표일이 되었다."));
     myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"5시에 발표라고 했으니까 얼마 안 남았네. 으, 떨려…"));
    yield return StartCoroutine(NormalChat(me,"…! 5시다!"));

    image1=GameObject.Find("Canvas1").GetComponent<Image>();
    image1.sprite = image3;
    yield return StartCoroutine(NormalChat(me,"1등은… 역시 난 아니네."));
    yield return StartCoroutine(NormalChat(me,"음… 엇, 3등에 "+me+"...?!!"));
    yield return StartCoroutine(NormalChat(me,"내가 3등이라고?!!"));
    whiteImage.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"그래도 시골까지 내려간 게 헛된 일은 아니었네!"));
    yield return StartCoroutine(NormalChat(me,"앗, 빨리 이 소식을 윤이수한테도 알려줘야겠다!"));
    whiteImage.gameObject.SetActive(false);

    image1=GameObject.Find("Canvas1").GetComponent<Image>();
    image1.sprite = image4;

    myTag.gameObject.SetActive(false);
    yield return StartCoroutine(NormalChat("","공모전에서 1등은 하지 못했지만 그후 나는 포포타입에서 로맨스 소설을 올리기 시작했다."));
    yield return StartCoroutine(NormalChat("","예전과 다르게 꽤 많은 사람들이 나의 글을 보고 응원해준다."));
    yield return StartCoroutine(NormalChat("","그리고 윤이수에게도 종종 응원 연락이 온다."));
    yield return StartCoroutine(NormalChat("","앞으로도 포기하지 않고 열심히 노력해서 더 뛰어난 작가가 될 거다!"));
    

    StartCoroutine(FadeCoroutine());
    Invoke("Load",3f);
    
   
 
    
   }

  
  
}


