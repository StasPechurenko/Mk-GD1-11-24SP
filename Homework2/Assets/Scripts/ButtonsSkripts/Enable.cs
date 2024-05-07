using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enable : MonoBehaviour
{
    public Button button;
    public Button[] disableButton;
    public TextMeshProUGUI text;
    void Start()
    {
        button.onClick.AddListener(() =>
        {
            text.text = "Buttons";
            for (int i = 0; i < disableButton.Length; i++)
            {
                if (disableButton[i].interactable != true)
                {
                    disableButton[i].interactable = true;
                }
            }; ;
        });

    }
}
