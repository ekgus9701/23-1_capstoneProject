using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HJBad : MonoBehaviour
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
    
   
    yield return StartCoroutine(NormalChat("??","야 "+me+". 어디 가?"));
    boyTag.gameObject.SetActive(false);
    
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"헉, 깜짝이야!"));
    yield return StartCoroutine(NormalChat(me,"소현재? 너 안 갔어?"));
    
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("소현재","나 먼저 가면 너 심심하게 혼자 올라가야 되잖아~"));
    yield return StartCoroutine(NormalChat("소현재","이제 올라갈 거야?"));

    boyTag.gameObject.SetActive(false);
     boyImage[1].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"응, 공모전도 끝났거든."));
    yield return StartCoroutine(NormalChat(me,"아, 혹시 내 소설 읽어볼래?"));
    yield return StartCoroutine(NormalChat(me,"사실 이 소설, 너 생각하면서 쓴 거야."));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("소현재","뭐? 나를? 정말로? 지금 읽어봐도 돼?"));
    yield return StartCoroutine(NormalChat("소현재","…"));

    boyImage[0].gameObject.SetActive(false);
    boyImage[4].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("소현재","어, 재밌네~"));

    boyTag.gameObject.SetActive(false);
    boyImage[4].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"진짜...?"));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[3].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("소현재","응. 뭐, 읽을 만해. 근데 중간에 문맥에 안 맞는 단어들은 뭐냐?"));
    yield return StartCoroutine(NormalChat("소현재","그래도 나랑 있었던 일로 이렇게 소설까지 써줘서 고맙다~"));
    yield return StartCoroutine(NormalChat("소현재","서울 가면 또 맛있는 거나 먹으러 가자~"));

    boyTag.gameObject.SetActive(false);
    boyImage[3].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"아, 당연하지! 고마워!"));
     

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
    yield return StartCoroutine(NormalChat(me,"그때 소현재도 그러더니… 내 어휘력이 문제였나?"));
     whiteImage.gameObject.SetActive(false);

    image1=GameObject.Find("Canvas1").GetComponent<Image>();
    image1.sprite = image4;

    myTag.gameObject.SetActive(false);
    yield return StartCoroutine(NormalChat("","결국 나는 이번 공모전에서도 상을 타지 못했다."));
    yield return StartCoroutine(NormalChat("","그리고 소현재에게도 아직까지 연락이 오지 않는다."));
    yield return StartCoroutine(NormalChat("","그래도 앞으로도 포기하지 않고 열심히 노력해서 더 뛰어난 작가가 되고 말 거다."));
    
    

    StartCoroutine(FadeCoroutine());
    Invoke("Load",3f);
    
   
 
    
   }

  
  
}


