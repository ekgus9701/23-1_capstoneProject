using UnityEngine;
using UnityEngine.UI;


public class FontManager : MonoBehaviour
{
    public Font targetFont; // 통일하려는 폰트

    private void Start()
    {
        // 모든 Text 및 TextMeshProUGUI 컴포넌트를 찾아서 폰트 설정
        SetFontInChildren<Text>();
        
    }
    

    private void SetFontInChildren<T>() where T : Component
    {
        T[] components = FindObjectsOfType<T>();
        foreach (T component in components)
        {
            if (component is Text textComponent)
            {
                textComponent.font = targetFont;
            }
            
        }
    }
}
