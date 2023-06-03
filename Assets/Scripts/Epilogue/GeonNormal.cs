using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GeonNormal : MonoBehaviour
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
    yield return StartCoroutine(NormalChat(me,"이건 오빠?"));
    
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("이건","혹시나 했는데 "+me+" 맞았네."));
    yield return StartCoroutine(NormalChat("이건","이제 떠나는 거야?"));

    boyTag.gameObject.SetActive(false);
     boyImage[1].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"네, 공모전도 끝났거든요."));
    yield return StartCoroutine(NormalChat(me,"아, 혹시 제 소설 읽어보실래요?"));
    yield return StartCoroutine(NormalChat(me,"사실 이 소설, 오빠 생각하면서 쓴 거예요. 헤헤."));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("이건","정말? 이거 영광인데? 지금 읽어볼게."));
    yield return StartCoroutine(NormalChat("이건","…"));

    boyImage[0].gameObject.SetActive(false);
    boyImage[3].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("이건","우와, 재밌네!"));

    boyTag.gameObject.SetActive(false);
    boyImage[3].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"정말요? 다행이다!"));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[3].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("이건","응. 흥미로운데? 게다가 "+me+" 어휘력도 좋은 것 같아."));
    yield return StartCoroutine(NormalChat("이건","또… 나를 소재로 이렇게 소설까지 써줬다 하니 더 기쁘네."));
    yield return StartCoroutine(NormalChat("이건","그럼 서울에 가서도 종종 연락하자."));

    boyTag.gameObject.SetActive(false);
    boyImage[3].gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"…! 네, 그럴게요! 고마워요!"));
     

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
    yield return StartCoroutine(NormalChat(me,"앗, 빨리 이 소식을 이건 오빠한테도 알려줘야겠다!"));
    whiteImage.gameObject.SetActive(false);

    image1=GameObject.Find("Canvas1").GetComponent<Image>();
    image1.sprite = image4;

    myTag.gameObject.SetActive(false);
    yield return StartCoroutine(NormalChat("","공모전에서 1등은 하지 못했지만 그후 나는 포포타입에서 로맨스 소설을 올리기 시작했다."));
    yield return StartCoroutine(NormalChat("","예전과 다르게 꽤 많은 사람들이 나의 글을 보고 응원해준다."));
    yield return StartCoroutine(NormalChat("","그리고 이건 오빠에게도 종종 응원 연락이 온다."));
    yield return StartCoroutine(NormalChat("","앞으로도 포기하지 않고 열심히 노력해서 더 뛰어난 작가가 될 거다!"));
    

    StartCoroutine(FadeCoroutine());
    Invoke("Load",3f);
    
   
 
    
   }

  
  
}


