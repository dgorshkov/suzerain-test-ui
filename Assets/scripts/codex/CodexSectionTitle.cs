using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class CodexSectionTitle : MonoBehaviour
{
    private TextMeshProUGUI tmpro;

    public void SetText(string newText)
    {
        tmpro = GetComponent<TextMeshProUGUI>();
        tmpro.text = newText;
    }

}
