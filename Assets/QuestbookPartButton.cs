using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestbookPartButton : MonoBehaviour
{

    [SerializeField] Sprite activeSprite;
    [SerializeField] Sprite inactiveSprite;
    [SerializeField] private string mySceneName;
    Image myImage;


    private void Start()
    {
        //find image component
        myImage = GetComponent<Image>();
        
        //always start inactive
        MakeLookInactive();
        
        //activate if this is the right scene
        if (SceneManager.GetActiveScene().name == mySceneName)
        {
            MakeLookActive();
        }
            
        
    }


    private void MakeLookActive()
    {
        myImage.sprite = activeSprite;

    }
    
    private void MakeLookInactive()
    {
        myImage.sprite = inactiveSprite;
    }


}
