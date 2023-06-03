using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage2_MinigameOX_result : MonoBehaviour
{
    public Text score_num;
    public Text score;
    public Text ESoo;

   int stage2_score=0; //맞힌 개수
    int stage2_score_w=0; //틀린개수
    int cal;

    float EsooLove;
    // Start is called before the first frame update
    void Start()
    {
        
        stage2_score=PlayerPrefs.GetInt("stage2_score");
       stage2_score_w=PlayerPrefs.GetInt("stage2_score_w");
        Debug.Log(stage2_score);
         Debug.Log(stage2_score_w);
        score_num.text=stage2_score.ToString();
        cal=stage2_score*5+(stage2_score_w)*(-5);
        
        score.text=cal.ToString();

        EsooLove=PlayerPrefs.GetFloat("EsooLove");
        ESoo.text=EsooLove.ToString();
        

    }

    public void load(){
        SceneManager.LoadScene("Stage3_0");
    }

   
   
}
