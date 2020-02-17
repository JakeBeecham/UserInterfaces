using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    public Image imgColor;

    public void GetColor(Button btnSource)
    {
        Image buttonImage = btnSource.GetComponent<Image>();
        imgColor.color = buttonImage.color;
    }
}
