using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodexItemPicture : MonoBehaviour
{

    private Image image;

    public void SetSprite(Sprite newSprite)
    {
        image = GetComponent<Image>();
        image.sprite = newSprite;
    }


}
