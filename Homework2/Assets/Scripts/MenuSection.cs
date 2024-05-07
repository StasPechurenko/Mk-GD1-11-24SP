using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSection : MonoBehaviour
{
    public Button[] buttons;
    public GameObject[] gameObjects;
    public Button back;
    public GameObject mainMenu;

    void Start()
    {

        for (int i = 0; i < buttons.Length; i++)
        {
            int buttonIndex = i;
            buttons[i].onClick.AddListener(() => OnButtonClick(buttonIndex, gameObjects, back, mainMenu));
        }
    }

    void OnButtonClick(int buttonIndex, GameObject[] gameObjects, Button back, GameObject mainMenu)
    {
        mainMenu.SetActive(false);
        back.gameObject.SetActive(true);
        gameObjects[buttonIndex].SetActive(true);

        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (i == buttonIndex)
            {
                continue;
            }
            gameObjects[i].SetActive(false);
        }
    }
}
