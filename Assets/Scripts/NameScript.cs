using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameScript : MonoBehaviour
{
    public InputField inputName;

    public void Save(){
        PlayerPrefs.SetString("Name",inputName.text);
        if(inputName.text==""){
            Debug.Log("아무것도 입력 안함");
        }
        if(inputName.text!=""){
             SceneManager.LoadScene("Prologue");
             Debug.Log("입력됨");
        }
            
    }
}
