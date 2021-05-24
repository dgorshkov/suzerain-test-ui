using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodexItemsList : MonoBehaviour
{

    [SerializeField] private GameObject itemButtonPrefab;
    private CodexItem[] groupItems;
    
    public void ShowItemsFromGroup(CodexGroup codexGroup)
    {

        ClearChildren();
        
        
        groupItems = codexGroup.GetItems();

        foreach (var item in groupItems)
        {
            GameObject itemButton = Instantiate(itemButtonPrefab, transform);
            itemButton.GetComponent<CodexItemButton>().SetItem(item);
        }
        
    }

    public void Clear()
    {
        ClearChildren();
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



