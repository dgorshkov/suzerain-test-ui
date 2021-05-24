using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CodexItemTitle : MonoBehaviour
{
    
    private TextMeshProUGUI tmpro;

    public void SetText(string newText)
    {
        tmpro = GetComponent<TextMeshProUGUI>();
        tmpro.text = newText;
    }
    
}
