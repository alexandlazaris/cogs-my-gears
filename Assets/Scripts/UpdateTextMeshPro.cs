using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateTextMeshPro : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textObject;

    // Update is called once per frame
    void UpdateText(string newText)
    {
        textObject.text = newText;
    }

    void UpdateTextUsingFloat(float newText)
    {
        textObject.text = newText.ToString();
    }
}
