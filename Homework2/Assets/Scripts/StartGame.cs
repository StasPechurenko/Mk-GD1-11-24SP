using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject [] menu;

    private void Start()
    {
        for (int i = 0; i < menu.Length; i++)
        {
            if (menu[i].activeSelf)
            {
                menu[i].SetActive(false);
            }
        }

        if (mainMenu.activeSelf==false)
        {
            mainMenu.SetActive(true);
        }
    }
}
