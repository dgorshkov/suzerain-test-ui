using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodexGroupList : MonoBehaviour
{

    [SerializeField] private GameObject groupButtonPrefab;
    private CodexGroup[] sectionGroups;


    public void ShowGroups(CodexSection section)
    {
        ClearChildren();
        
        
        sectionGroups = section.GetGroups();

        foreach (var gr in sectionGroups)
        {
            GameObject itemButton = Instantiate(groupButtonPrefab, transform);
            itemButton.GetComponent<CodexGroupButton>().SetGroup(gr);
        }
    }

    
    private void ClearChildren()
    {
        int i = 0;

        //Array to hold all child obj
        GameObject[] allChildren = new GameObject[transform.childCount];

        //Find all child obj and store to that array
        foreach (Transform child in transform)
        {
            allChildren[i] = child.gameObject;
            i += 1;
        }

        //Now destroy them
        foreach (GameObject child in allChildren)
        {
            Destroy(child.gameObject);
        }
        
    }
    

}
