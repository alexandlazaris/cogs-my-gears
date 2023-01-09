using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUnityUIText : MonoBehaviour
{
    [SerializeField]
    private Text _timerText;
    
   void UpdateText(string newText)
    {
        _timerText.text = newText;
    }

    void UpdateTextUsingFloat(float newText)
    {
        _timerText.text = newText.ToString();
    }
}
