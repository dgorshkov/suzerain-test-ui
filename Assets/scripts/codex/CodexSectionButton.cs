using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodexSectionButton : MonoBehaviour
{
    [SerializeField] private CodexSection mySection;
    [SerializeField] private bool iAmDefault;
    
    [SerializeField] private Sprite activeStateSprite;
    [SerializeField] private Sprite inactiveStateSprite;
    
    [SerializeField] private GameObject iconObj;
    [SerializeField] private Sprite activeIconSprite;
    [SerializeField] private Sprite inactiveIconSprite;

    private CodexSectionTitle sectionTitle;
    private CodexGroupList groupList;
    private CodexItemsList itemList;

    private void Start()
    {
        //find all the stuff
        sectionTitle = FindObjectOfType<CodexSectionTitle>();
        groupList = FindObjectOfType<CodexGroupList>(); 
        itemList = FindObjectOfType<CodexItemsList>();

        //switch to inactive
        MakeLookInactive();


        //set to active if default
        if (iAmDefault)
        {
            SwitchToMySection();
        }
        
    }
    
    
    public void SwitchToMySection()
    {
        //make all buttons inactive
        CodexSectionButton[] allSectionButtons = FindObjectsOfType<CodexSectionButton>();
        foreach (var button in allSectionButtons)
        {
            button.MakeLookInactive();
        }
        
        //change this button state
        MakeLookActive();
        
        //update section title
        string sectionName = mySection.GetTitle();
        sectionTitle.SetText(sectionName);
        
        //update groups list
        groupList.ShowGroups(mySection);
        
        //clear items list
        itemList.Clear();

    }

    private void MakeLookActive()
    {
        Image myImage = GetComponent<Image>();
        myImage.sprite = activeStateSprite;
        
        Image iconImage = iconObj.GetComponent<Image>();
        iconImage.sprite = activeIconSprite;

    }    
    
    private void MakeLookInactive()
    {
        Image myImage = GetComponent<Image>();
        myImage.sprite = inactiveStateSprite;
        
        Image iconImage = iconObj.GetComponent<Image>();
        iconImage.sprite = inactiveIconSprite;

    }
    

}
