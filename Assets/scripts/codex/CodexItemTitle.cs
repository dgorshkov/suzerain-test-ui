using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CodexItemTitle : MonoBehaviour
{
    
    private TextMeshProUGUI tmpro;
    private void Start()
    {
        tmpro = GetComponent<TextMeshProUGUI>();
    }

    public void SetText(string newText)
    {
        tmpro.text = newText;
    }
    
}
