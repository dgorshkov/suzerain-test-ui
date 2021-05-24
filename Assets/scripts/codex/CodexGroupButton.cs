using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CodexGroupButton : MonoBehaviour
{

    [SerializeField] private CodexGroup myCodexGroup;
    [SerializeField] private GameObject buttonTextObj;
    private CodexItemsList itemsList;
    
    [SerializeField] private Sprite activeSprite;
    [SerializeField] private Sprite inactiveSprite;
    
    
    void Start()
    {
        //set button text
        TextMeshProUGUI buttonTextTMPro = buttonTextObj.GetComponent<TextMeshProUGUI>();
        buttonTextTMPro.text = myCodexGroup.GetTitle();
        
        //start in inactive state
        MakeLookInactive();

        
        //find the items list
        itemsList = FindObjectOfType<CodexItemsList>();

    }

    public void SetGroup(CodexGroup newCodexGroup)
    {
        myCodexGroup = newCodexGroup;
    }

    public void RevealMyGroup()
    {
        itemsList.ShowItemsFromGroup(myCodexGroup);
        
        //deactivate all buttons
        CodexGroupButton[] groupButtons = FindObjectsOfType<CodexGroupButton>();
        foreach (var button in groupButtons)
        {
            button.MakeLookInactive();
        }
        
        //change button look to active
        MakeLookActive();
        

        
    }

    private void MakeLookActive()
    {
        Image myImage = GetComponent<Image>();
        myImage.sprite = activeSprite;
    }

    public void MakeLookInactive()
    {
        Image myImage = GetComponent<Image>();
        myImage.sprite = inactiveSprite;
    }
    

}
