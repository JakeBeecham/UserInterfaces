using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    public Text txtOnChanged;
    public Text txtOnFinished;
    public InputField txtInput;

    //as the text changes, this method will be called
    public void UpdateName(string name)
    {
        txtOnChanged.text = txtInput.text;
    }

    //called when the user has finsihed entering text
    public void NameFinished(string name)
    {
        txtOnFinished.text = txtInput.text;
    }
}
