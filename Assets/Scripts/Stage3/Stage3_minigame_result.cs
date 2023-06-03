using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage3_minigame_result : MonoBehaviour
{
    public Text score_num;
    public Text score;
    public Text HJ;

   int stage3_score=0; //맞힌 개수
    int stage3_score_w=0; //틀린개수
    int cal;

    float HJLove;
    // Start is called before the first frame update
    void Start()
    {
        
        stage3_score=PlayerPrefs.GetInt("stage3_score");
       stage3_score_w=PlayerPrefs.GetInt("stage3_score_w");
        Debug.Log(stage3_score);
         Debug.Log(stage3_score_w);
        score_num.text=stage3_score.ToString();
        cal=stage3_score*5+(stage3_score_w)*(-5);
        
        score.text=cal.ToString();

        HJLove=PlayerPrefs.GetFloat("HJLove");
        HJ.text=HJLove.ToString();
        

    }

    public void load(){
        SceneManager.LoadScene("Epilogue");
    }

   
   
}
