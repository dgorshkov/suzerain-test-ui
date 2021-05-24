using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CodexItemButton : MonoBehaviour
{

    [SerializeField] private CodexItem codexItem;
    [SerializeField] private GameObject buttonTextObj;
    
    [SerializeField] private Color activeTextColor;
    [SerializeField] private Color inactiveTextColor;
    [SerializeField] private TMP_FontAsset regularFont;
    [SerializeField] private TMP_FontAsset boldFont;
    
    private TextMeshProUGUI tmpro;
    
    void Start()
    {
        //get button text from codex item
        tmpro = buttonTextObj.GetComponent<TextMeshProUGUI>();
        tmpro.text = codexItem.GetTitle();
        
        //start as inactive
        MakeLookInactive();
    }

    public void SetItem(CodexItem item)
    {
        codexItem = item;
    }
    
    public void ShowMyItem()
    {
        CodexItemView itemView = FindObjectOfType<CodexItemView>();
        itemView.ShowItem(codexItem);
        
        //deactivate other buttons
        CodexItemButton[] itemButtons = FindObjectsOfType<CodexItemButton>();
        foreach (var button in itemButtons)
        {
            button.MakeLookInactive();
        }
        
        //make me look active
        MakeLookActive();


    }


    public void MakeLookInactive()
    {
        tmpro.color = inactiveTextColor;
        tmpro.font = regularFont;
    }

    public void MakeLookActive()
    {
        tmpro.color = activeTextColor;
        tmpro.font = boldFont;

    }
}
