using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Exit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

      public Text textComponent1;
   
      public Color originalColor = Color.white;
      

      void Start()
      {
            textComponent1.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0.5f);
            
      }

      public void OnPointerEnter(PointerEventData eventData)
      {
            textComponent1.color = new Color(originalColor.r, originalColor.g, originalColor.b, 1f);
            
      }

      public void OnPointerExit(PointerEventData eventData)
      {
            textComponent1.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0.5f);
      }
       
      public void ExitButton(){
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #elif UNITY_WEBPLAYER
            Application.OpenURL(webplayerQuitURL);
            #else
            Application.Quit();
            #endif
            
      }
}

