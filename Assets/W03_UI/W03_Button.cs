using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class W03_Button : MonoBehaviour
{
    public TMP_Text InputText, OutputText;

    public void OnClickTest()
    {
        print("click");
    }

    public void OnClickSetText()
    {
        OutputText.text = InputText.text;
    }
}
