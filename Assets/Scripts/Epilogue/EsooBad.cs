using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EsooBad : MonoBehaviour
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
    boyImage[4].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("윤이수","…어, 재밌네."));

    boyTag.gameObject.SetActive(false);
    boyImage[4].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"진짜...?"));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[3].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("윤이수","응. 괜찮아. 근데 문맥에 안 맞는 단어들이 좀 있다?"));
    yield return StartCoroutine(NormalChat("윤이수","그래도 나랑 있었던 일로 이렇게 소설까지 써준 건 신기하네. 고맙다! "));
    yield return StartCoroutine(NormalChat("윤이수","서울 가서도 잘 지내고."));

    boyTag.gameObject.SetActive(false);
    boyImage[3].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"아… 응, 고마워."));
     

    image1.sprite = image2;
    myTag.gameObject.SetActive(false);
    yield return StartCoroutine(NormalChat("","시간은 빠르게 흘러 어느덧 공모전 결과 발표일이 되었다."));
     myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"5시에 발표라고 했으니까 얼마 안 남았네. 으, 떨려…"));
    yield return StartCoroutine(NormalChat(me,"…! 5시다!"));

    image1=GameObject.Find("Canvas1").GetComponent<Image>();
    image1.sprite = image3;

    yield return StartCoroutine(NormalChat(me,"1등은… 역시 난 아니네."));
    yield return StartCoroutine(NormalChat(me,"2등, 3등도… 내 이름은 없네."));
     whiteImage.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"그때 윤이수도 그러더니… 내 어휘력이 문제였나?"));
     whiteImage.gameObject.SetActive(false);

    image1=GameObject.Find("Canvas1").GetComponent<Image>();
    image1.sprite = image4;

    myTag.gameObject.SetActive(false);
    yield return StartCoroutine(NormalChat("","결국 나는 이번 공모전에서도 상을 타지 못했다."));
    yield return StartCoroutine(NormalChat("","그리고 윤이수에게도 아직까지 연락이 오지 않는다."));
    yield return StartCoroutine(NormalChat("","그래도 앞으로도 포기하지 않고 열심히 노력해서 더 뛰어난 작가가 되고 말 거다."));
    
    

    StartCoroutine(FadeCoroutine());
    Invoke("Load",3f);
    
   
 
    
   }

  
  
}


