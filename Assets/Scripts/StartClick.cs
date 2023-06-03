using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class StartClick : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{   
    public Text textComponent1;
   
    public Color originalColor = Color.white;
    

    void Start()
    {
        textComponent1.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0.5f);
        PlayerPrefs.DeleteAll();
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        textComponent1.color = new Color(originalColor.r, originalColor.g, originalColor.b, 1f);
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        textComponent1.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0.5f);
       
    }

    public void startClick(){
        SceneManager.LoadScene("SetName");
    }
   
}
