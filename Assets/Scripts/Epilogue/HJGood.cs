using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HJGood : MonoBehaviour
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
    boyImage[2].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("소현재",me+"... 글 너무 좋은데?"));

    boyTag.gameObject.SetActive(false);
    boyImage[2].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"진짜? 다행이다!"));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[2].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("소현재","응. 이번엔 너 정말 상 탈 것 같은데? 게다가 "+me+" 어휘력도 왜 이렇게 좋아졌지?"));
    yield return StartCoroutine(NormalChat("소현재","또… 나랑 있었던 일로 이렇게 소설까지 써줬다고 생각하니까 나 왜 이렇게 기쁘지?"));
    yield return StartCoroutine(NormalChat("소현재","…서울 가면 나랑 놀아주면 안 돼?"));

    boyTag.gameObject.SetActive(false);
    boyImage[2].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"…! 야, 당연하지! 고마워!"));
     

    image1.sprite = image2;
    myTag.gameObject.SetActive(false);
    yield return StartCoroutine(NormalChat("","시간은 빠르게 흘러 어느덧 공모전 결과 발표일이 되었다."));
     myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"5시에 발표라고 했으니까 얼마 안 남았네. 으, 떨려…"));
    yield return StartCoroutine(NormalChat(me,"…! 5시다!"));

    image1=GameObject.Find("Canvas1").GetComponent<Image>();
    image1.sprite = image3;

    yield return StartCoroutine(NormalChat(me,"1등은… "+me+"...?!!"));
    yield return StartCoroutine(NormalChat(me,"내가 1등이라고?!!"));
    whiteImage.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"시골까지 내려가서 그렇게 열심히 글을 쓴 보람이 있구나!"));
    yield return StartCoroutine(NormalChat(me,"앗, 빨리 이 소식을 소현재한테도 알려줘야겠다!"));
    whiteImage.gameObject.SetActive(false);

    image1=GameObject.Find("Canvas1").GetComponent<Image>();
    image1.sprite = image4;

    myTag.gameObject.SetActive(false);
    yield return StartCoroutine(NormalChat("","그렇게 나는 포포타입에서 로맨스 소설을 연재하는 작가가 되었다."));
    yield return StartCoroutine(NormalChat("","예전과 다르게 많은 사람들이 나의 글을 보고 응원해준다."));
    yield return StartCoroutine(NormalChat("","그리고 누구보다 날 응원해주는 남자친구도 만나게 되었다!"));
    yield return StartCoroutine(NormalChat("","앞으로도 열심히 노력해서 지금보다 더 멋진 작가가 될 거다!"));
    yield return StartCoroutine(NormalChat("","그전에 일단 남자친구랑 데이트 좀 하고~!"));
    

    StartCoroutine(FadeCoroutine());
    Invoke("Load",3f);
    
   
 
    
   }

  
  
}


