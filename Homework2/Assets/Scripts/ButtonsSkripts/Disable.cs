using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disable : MonoBehaviour
{
    public Button button;
    public Button[] disableButton;
    void Start()
    {
        button.onClick.AddListener(() =>
        {
            for (int i = 0; i < disableButton.Length; i++)
            {
                if (disableButton[i].IsActive())
                {
                    disableButton[i].interactable = false;
                }
            }; ;
        });
    }
}
