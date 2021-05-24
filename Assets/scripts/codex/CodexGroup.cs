using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Codex Group")]

public class CodexGroup : ScriptableObject
{

    [SerializeField] string title;
    [SerializeField] CodexItem[] items;

    public string GetTitle()
    {
        return title;
    }

    public CodexItem[] GetItems()
    {
        return items;
    }
    
}
