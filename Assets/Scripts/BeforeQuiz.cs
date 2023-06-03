using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeforeQuiz : MonoBehaviour
{
    
    public void Load(){
        SceneManager.LoadScene("Stage1_minigame");
    }
     public void Load2(){
        SceneManager.LoadScene("Stage2_Minigame_OX");
    }

     public void Load3(){
        SceneManager.LoadScene("Stage3_minigame");
    }
}
