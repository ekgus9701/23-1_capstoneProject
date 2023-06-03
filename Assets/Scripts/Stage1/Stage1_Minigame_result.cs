using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage1_Minigame_result : MonoBehaviour
{
    public Text score_num;
    public Text score;
    public Text Egeon;

    int stage1_score;
    int stage1_score_w;
    int cal;
    float GeonLove;
    // Start is called before the first frame update
    void Start()
    {
        stage1_score=PlayerPrefs.GetInt("stage1_score");
        stage1_score_w=PlayerPrefs.GetInt("stage1_score_w");
        score_num.text=stage1_score.ToString();
        cal=stage1_score*5+(stage1_score_w)*(-5);
        //Debug.Log(stage1_score_w);
        score.text=cal.ToString();
        GeonLove=PlayerPrefs.GetFloat("GeonLove");
        Egeon.text=GeonLove.ToString();
        

    }

    public void load(){
        SceneManager.LoadScene("Stage2_1");
    }

   
   
}
