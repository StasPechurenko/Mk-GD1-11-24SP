using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropDawnMenu : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void InputMenu(int value)
    {
        switch (value)
        {
            case 0:
                text.text = "Option A";
                break;
            case 1:
                text.text = "Option B";
                break;
            case 2:
                text.text = "Option C";
                break;
            case 3:
                text.text = "Option D";
                break;
            default:
                break;
        }
    }
}
