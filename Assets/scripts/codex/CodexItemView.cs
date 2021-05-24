using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodexItemView : MonoBehaviour
{

    private CodexItemTitle titleObj;
    private CodexItemPicture pictureObj;
    private CodexItemDescription descriptionObj;
    
    private void Start()
    {
        titleObj = FindObjectOfType<CodexItemTitle>();
        pictureObj = FindObjectOfType<CodexItemPicture>();
        descriptionObj = FindObjectOfType<CodexItemDescription>();
        
        //hide everything at the start
        HideContent();
    }

    public void ShowItem(CodexItem item)
    {
        
        string title = item.GetTitle();
        Sprite image = item.GetImage();
        string description = item.GetDescription();

        titleObj.SetText(title);
        pictureObj.SetSprite(image);
        descriptionObj.SetText(description);
        
        UnhideContent();
        
    }

    private void HideContent()
    {
        titleObj.gameObject.SetActive(false);
        pictureObj.gameObject.SetActive(false);
        descriptionObj.gameObject.SetActive(false);
    }

    private void UnhideContent()
    {
        titleObj.gameObject.SetActive(true);
        pictureObj.gameObject.SetActive(true);
        descriptionObj.gameObject.SetActive(true);
    }
    
    
    
    
    
}
