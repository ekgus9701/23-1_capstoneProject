using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Write : MonoBehaviour
{
  public InputField word1;
  public InputField word2;
  public InputField word3;
  public InputField word4;
  public InputField word5;
  public InputField word6;
  public InputField word7;
  public InputField word8;
  public InputField word9;


    public void CaptureScreen()
    {
        string timestamp = System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        string fileName = "어휘 공부" + timestamp + ".png";
        
       
        CaptureScreenForPC(fileName);
        
    }

    private void CaptureScreenForPC(string fileName)
    {
        ScreenCapture.CaptureScreenshot(fileName);
    }

    public void load1(){
        if(word1.text!=""&&word2.text!=""&&word3.text!="")
            SceneManager.LoadScene("Epilogue2_2");
    }
    public void load2(){
        if(word4.text!=""&&word5.text!=""&&word6.text!="")
            SceneManager.LoadScene("Epilogue2_3");
    }
     public void load3(){
        if(word7.text!=""&&word8.text!=""&&word9.text!="")
            SceneManager.LoadScene("Epilogue3");
    }
}
