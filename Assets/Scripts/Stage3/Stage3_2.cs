using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage3_2 : MonoBehaviour
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
    float HJLove=0f;
    
   

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
     SceneManager.LoadScene("Stage3_2_1");
   }
    public void Load2(){
     SceneManager.LoadScene("Stage3_2_2");
   }
    public void Load3(){
     SceneManager.LoadScene("Stage3_2_3");
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
    yield return StartCoroutine(NormalChat(me,"...그래서, 대충 이런 이야기야."));
    
    boyTag.gameObject.SetActive(true);
    CharacterName.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("소현재","오… 뭐야? 줄거리는 완전 흥미로운데?"));
    yield return StartCoroutine(NormalChat("소현재","글 제대로 읽어보고 싶다. 글 써 둔 거 보여주라. 응~?"));
    boyImage[1].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);


    yield return StartCoroutine(NormalChat(me,"안 돼. 사실 아직 자세하게는 못 썼단 말이야."));
    yield return StartCoroutine(NormalChat(me,"그냥 온 김에 밥 먹고 대충 놀다가 가, 너."));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("소현재","뭐? 아직 다 안 썼어?"));
    yield return StartCoroutine(NormalChat("소현재","너 분명 여기서 완성까지 해갈 거라고 하지 않았냐?"));
    
    boyImage[0].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat(me,"아직 마감일 좀 남았잖아."));
    yield return StartCoroutine(NormalChat(me,"그리고 이번에 진짜 잘 쓰고 싶어서 고민하다 보니까 더 부담돼서 글이 안 써지는 걸 어떡해!"));
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("소현재","아니, 그게…"));
    yield return StartCoroutine(NormalChat("소현재","…너 그냥 다시 서울로 올라오면 안 되냐?"));
    yield return StartCoroutine(NormalChat("소현재","사실 난 처음부터 네가 혼자 시골에서 지내는 것부터… 걱정됐단 말이야."));
    yield return StartCoroutine(NormalChat("소현재","서울에 있으면 나랑 다른 애들도 있고, 적어도 외롭진 않을 것 같은데."));
    yield return StartCoroutine(NormalChat("소현재","고집쟁이도 아니고… 꼭 이렇게 시골에서 글 쓰는 걸 고수해야 돼?"));

    boyImage[0].gameObject.SetActive(false);
  
    b1.SetActive(true);
    b2.SetActive(true);
    b3.SetActive(true);
    
   }

}


