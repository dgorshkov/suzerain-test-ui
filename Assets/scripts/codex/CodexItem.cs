using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Codex Item")]

public class CodexItem : ScriptableObject
{
    
    [SerializeField] string title;
    [SerializeField] Sprite image;
    [TextArea(10,10)] [SerializeField] string description;

    public string GetTitle()
    {
        return title;
    }

    public Sprite GetImage()
    {
        return image;
    }

    public string GetDescription()
    {
        return description;
    }
    
    
}
