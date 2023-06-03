using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class BoyChoose : MonoBehaviour
{
    public GameObject boy1;
    public GameObject boy2;
    public GameObject boy3;

    public Image Geon;
    private Outline GeonLine;
    public Image HJ;
    private Outline HJLine;
    public Image Esoo;
    private Outline EsooLine;

    float GeonLove;
    float EsooLove;
    float HJLove;

   

    void Start(){

        
        
        GeonLine=Geon.GetComponent<Outline>();
        HJLine=HJ.GetComponent<Outline>();
        EsooLine=Esoo.GetComponent<Outline>();
        

    }

    public void click1(){
        boy1.SetActive(true);
        boy2.SetActive(false);
        boy3.SetActive(false);
        GeonLine.enabled=true;
        HJLine.enabled=false;
        EsooLine.enabled=false;
    }

    public void click2(){
        boy1.SetActive(false);
        boy2.SetActive(true);
        boy3.SetActive(false);
        GeonLine.enabled=false;
        HJLine.enabled=false;
        EsooLine.enabled=true;

    }

    public void click3(){
        boy1.SetActive(false);
        boy2.SetActive(false);
        boy3.SetActive(true);
        GeonLine.enabled=false;
        HJLine.enabled=true;
        EsooLine.enabled=false;
        
    }

    public void Load(){
        //Debug.Log("aa");
        if(boy1.activeSelf){
            GeonLove=PlayerPrefs.GetFloat("GeonLove");
            Debug.Log(GeonLove);
            if(GeonLove>=40){
                SceneManager.LoadScene("GeonGood");
            }
            else if(GeonLove>=25){
                SceneManager.LoadScene("GeonNormal");
            }
            else{
                SceneManager.LoadScene("GeonBad");
            }
        }

        else if(boy2.activeSelf){
            EsooLove=PlayerPrefs.GetFloat("EsooLove");
            Debug.Log(EsooLove);
            if(EsooLove>=40){
                SceneManager.LoadScene("EsooGood");
            }
            else if(EsooLove>=25){
                SceneManager.LoadScene("EsooNormal");
            }
            else{
                SceneManager.LoadScene("EsooBad");
            }

        }

        else{
            HJLove=PlayerPrefs.GetFloat("HJLove");
            Debug.Log(HJLove);
            if(HJLove>=40){
                SceneManager.LoadScene("HJGood");
            }
            else if(HJLove>=25){
                SceneManager.LoadScene("HJNormal");
            }
            else{
                SceneManager.LoadScene("HJBad");
            }
        }
    }

   
}
