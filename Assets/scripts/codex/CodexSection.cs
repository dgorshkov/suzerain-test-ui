using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Codex Section")]

public class CodexSection : ScriptableObject
{

    [SerializeField] string id;
    [SerializeField] string title;
    [SerializeField] CodexGroup[] sectionGroups;

    public string GetID()
    {
        return id;
    }

    public string GetTitle()
    {
        return title;
    }

    public CodexGroup[] GetGroups()
    {
        return sectionGroups;
    }
    
}
