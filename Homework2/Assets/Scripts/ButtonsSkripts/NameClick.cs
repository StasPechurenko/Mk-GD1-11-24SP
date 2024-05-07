using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameClick : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Button button;
    void Start()
    {
        button.onClick.AddListener(() => { text.text = button.GetComponentInChildren<TextMeshProUGUI>().text+" Clicked"; ; });
    }
}
