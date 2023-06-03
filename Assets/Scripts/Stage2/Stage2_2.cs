using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage2_2 : MonoBehaviour
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
     SceneManager.LoadScene("Stage2_2_1");
   }
    public void Load2(){
     SceneManager.LoadScene("Stage2_2_2");
   }
    public void Load3(){
     SceneManager.LoadScene("Stage2_2_3");
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
   
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);


    yield return StartCoroutine(NormalChat("윤이수","뭐, 아무튼. 아까 그 노트도… 많이 놀랐냐?"));
    

    boyImage[0].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat(me,"어, 없어졌을 때 좀 놀라긴 했지."));
    yield return StartCoroutine(NormalChat(me,"이 노트가 내가 중학교 때부터 써오던 아이디어 노트거든. 나한테는 정말 소중한 노트야."));
    yield return StartCoroutine(NormalChat(me,"그런데 뭐, 애들이 그런 거니까. 그리고 찾았으니까 괜찮아."));
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("윤이수","다행이네. 걔네가 그래도 그렇게 나쁜 애들은 아니야."));
    yield return StartCoroutine(NormalChat("윤이수","안 그래도 내가 걔네한테 물어보니까 너가 소설 쓰는 게 멋있어보여서 구경하고 싶었대."));
    yield return StartCoroutine(NormalChat("윤이수","물론 허락 없이 함부로 가져간 건 혼나야 하는 일이긴 하지만."));

    boyImage[1].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);
    yield return StartCoroutine(NormalChat(me,"음... 내가 진짜 작가도 아니고. 아직은 그냥 글 좀 끄적이는 고딩일 뿐인데."));
    yield return StartCoroutine(NormalChat(me,"다들 왜 그렇게 신기해하는 거지? 조금 부끄럽고, 민망하네."));
    yield return StartCoroutine(NormalChat(me,"사실 잘 모르겠어. 여기 온 지도 며칠이 지났는데 아직 괜찮은 글은 쓰지도 못했고."));
    yield return StartCoroutine(NormalChat(me,"작가가 되려면 더 노력해야 할 텐데 그냥 놀고만 있는 것 같고…"));
    yield return StartCoroutine(NormalChat(me,"어휴, 처음 본 애한테 별말을 다 하네. 미안. 그냥 잊어주라."));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);

     yield return StartCoroutine(NormalChat("윤이수","아니, 뭐. 널 처음 본 것도 맞고, 소설인지 뭔지 난 잘 모르긴 한데."));
     yield return StartCoroutine(NormalChat("윤이수","그 노트를 보니 나는 너가 잘 될 수 있을 것 같다."));
    boyImage[0].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat(me,"응?"));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);

     yield return StartCoroutine(NormalChat("윤이수","아니, 그 노트. 아이디어 노트라며."));
     yield return StartCoroutine(NormalChat("윤이수","작가가 되려고 그렇게 노트가 해지도록 뭔가를 계속 써왔다는 거 아니냐?"));
     yield return StartCoroutine(NormalChat("윤이수","겉으로는 부족해 보일지라도 이면에는 분명 엄청난 노력이 있을 거라고 본다."));



    boyImage[1].gameObject.SetActive(false);
    b1.SetActive(true);
    b2.SetActive(true);
    b3.SetActive(true);
    
  
 
    
   }

  
  
}


