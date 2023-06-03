using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage3_1 : MonoBehaviour
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
     SceneManager.LoadScene("Stage3_1_1");
   }
    public void Load2(){
     SceneManager.LoadScene("Stage3_1_2");
   }
    public void Load3(){
     SceneManager.LoadScene("Stage3_1_3");
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
    yield return StartCoroutine(NormalChat(me,"우와, 역시 읍내는 사람이 꽤 많네."));
    yield return StartCoroutine(NormalChat(me,"나는 슈퍼나 가야겠다~ 뭐 먹을까?"));

    myTag.gameObject.SetActive(false);
    CharacterName.gameObject.SetActive(false);

    yield return StartCoroutine(NormalChat("","그 순간, 누군가 내 뒤에서 내 어깨를 가볍게 쳤다."));

    boyTag.gameObject.SetActive(true);
    CharacterName.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("??","워!"));
    boyImage[0].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);


    yield return StartCoroutine(NormalChat(me,"악, 깜짝이야!!!!!"));
    
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("소현재","크크큭, "+me+" 표정 장난 아닌데?"));
    yield return StartCoroutine(NormalChat("소현재","역시 "+me+"(이)는 놀리는 맛이 있다니까."));
    
    boyImage[0].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat(me,"뭐야, 소현재?!!?"));
    yield return StartCoroutine(NormalChat(me,"네가 왜 여기서 나와?"));
    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[1].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("소현재","왜겠냐? "+me+"(이)가 여기서 혼자 외롭게 글 쓰고 있다는데, 안 올 수가 있겠냐?"));
    yield return StartCoroutine(NormalChat("소현재","혼자 또 삽질하고 있을 게 뻔하잖아~"));

    boyImage[1].gameObject.SetActive(false);
    boyTag.gameObject.SetActive(false);
    myTag.gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat(me,"아니, 뭐 그렇다고 여기까지 오냐…"));
    yield return StartCoroutine(NormalChat(me,"…그래도 고맙네."));

    myTag.gameObject.SetActive(false);
    boyTag.gameObject.SetActive(true);
    boyImage[0].gameObject.SetActive(true);

    yield return StartCoroutine(NormalChat("소현재","나 같은 친구가 또 어디 있냐?"));
    yield return StartCoroutine(NormalChat("소현재","그나저나, 소설은 어떻게 돼가고 있어?"));
    yield return StartCoroutine(NormalChat("소현재","개괄적인 이야기 좀 들려주면 안 되냐? 그니까 줄거리 좀 대강 추려서 알려줘."));

    boyImage[0].gameObject.SetActive(false);
  
    b1.SetActive(true);
    b2.SetActive(true);
    b3.SetActive(true);
    
   }

}


