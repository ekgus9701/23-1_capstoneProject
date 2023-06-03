using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage2_1 : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
    public Image image;
    public Image myTag;
    public Image boyTag;
    public Image childTag;
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
     SceneManager.LoadScene("Stage2_1_1");
   }
    public void Load2(){
     SceneManager.LoadScene("Stage2_1_2");
   }
    public void Load3(){
     SceneManager.LoadScene("Stage2_1_3");
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
    yield return StartCoroutine(NormalChat(me,"와아! 경치 진짜 미쳤다!"));
    yield return StartCoroutine(NormalChat(me,"좋아! 열심히 해보는 거야!"));
    yield return StartCoroutine(NormalChat(me,"…"));
    yield return StartCoroutine(NormalChat(me,"……"));
    yield return StartCoroutine(NormalChat(me,"끄응, 집중을 너무 빡세게 했나… 조금 뻐근하네."));
    yield return StartCoroutine(NormalChat(me,"잠깐 주변 좀 걷고 와야겠다."));

    myTag.gameObject.SetActive(false);
    
    childTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("아이 1","갔나? 갔지?"));
    yield return StartCoroutine(NormalChat("아이 2","저 누나가 그 소설 쓴다던 누나 맞지?"));
    yield return StartCoroutine(NormalChat("아이 2","여기서 뭐 쓰고 있나 봐!"));
    yield return StartCoroutine(NormalChat("아이 1","저기 노트도 있다!"));
    yield return StartCoroutine(NormalChat("아이 1","나 구경할래!"));
    yield return StartCoroutine(NormalChat("아이 2","나도!"));

    childTag.gameObject.SetActive(false);
    CharacterName.gameObject.SetActive(false);

    yield return StartCoroutine(NormalChat("","5분 후."));

    myTag.gameObject.SetActive(true);
    CharacterName.gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat(me,"아, 좀 걸으니까 잠도 깨고 좋다!"));
    yield return StartCoroutine(NormalChat(me,"이제 다시 또 열심히 글을 써 볼… 어라?"));
    yield return StartCoroutine(NormalChat(me,"뭐야?? 내 노트 어디 갔지??!!"));
    yield return StartCoroutine(NormalChat(me,"…"));
    yield return StartCoroutine(NormalChat(me,"잠깐… 아까 어떤 애기들이 지나가지 않았었나?"));
    yield return StartCoroutine(NormalChat(me,"…뭔가 손에 들고 있었던 것 같기도…"));
    yield return StartCoroutine(NormalChat(me,"아!! 어쩐지 뭔가 일이 술술 잘 풀린다고 했어. 그럼 그렇지!!"));
    yield return StartCoroutine(NormalChat(me,"걔네는 또 어떻게 찾냐고… 킹 받네, 진짜…"));
    CharacterName.gameObject.SetActive(false);
    myTag.gameObject.SetActive(false);
    yield return StartCoroutine(NormalChat("","충격을 받고 정자에 누워 있던 나에게 누군가 말을 걸었다."));

    boyTag.gameObject.SetActive(true);
    CharacterName.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("??","어이."+me+"작가님?"));
    boyImage[0].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"...누구세요?"));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat("??","그건 알 거 없고, 이거 찾고 있지?"));
    boyImage[0].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);


    yield return StartCoroutine(NormalChat(me,"헉! 내 노트!"));
    yield return StartCoroutine(NormalChat(me,"정말 감사합니다…"));
    yield return StartCoroutine(NormalChat(me,"근데 어떻게 찾으셨어요? 애들이 가져간 것 같았는데…"));
    yield return StartCoroutine(NormalChat(me,"아니아니, 제 이름은 어떻게 아신 거예요?"));
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("??","큭큭. 이 좁아터진 시골 동네에 비밀이 어디 있냐? 김씨 할머니 손녀가 소설 쓰러 왔다고 이미 소문 쫙 퍼졌지."));
    yield return StartCoroutine(NormalChat("윤이수","아, 너도 18살 맞지? 나는 윤이수고 너랑 동갑이야."));
    yield return StartCoroutine(NormalChat("윤이수","그니까 그냥 말 편하게 해라. 존댓말 낯간지러워서 죽겠다."));

    boyImage[0].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat(me,"헉, 소문이 났다고?"));
    yield return StartCoroutine(NormalChat(me,"생각해 보니 밖에 나가면 뭔가 시선이 느껴지긴 했었는데, 기분 탓이 아니었나…"));
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("윤이수","뭐? 그랬냐? 아, 내가 애 부담스럽게 하지 말라니까…"));
    yield return StartCoroutine(NormalChat("윤이수","야, 미안하다. 내가 대신 사과할게. 여자애 혼자 소설 쓰러 왔다니까 다들 신기하고 그, 기특해서 그런 거였을 거야."));
    yield return StartCoroutine(NormalChat("윤이수","그래도 이 동네가 외지인들 따돌리고 그런 곳은 아니야. 혹시 너무 배타적이라고 오해하지는 않았으면 좋겠다."));


    boyImage[0].gameObject.SetActive(false);
    b1.SetActive(true);
    b2.SetActive(true);
    b3.SetActive(true);
    
  
 
    
   }

  
  
}


