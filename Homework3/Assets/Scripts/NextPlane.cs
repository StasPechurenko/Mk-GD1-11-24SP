using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NextPlane : MonoBehaviour
{
    public GameObject[] plane;
    public int direction;
    private int count;

    public void ActivePlane()
    {
        for (int i = 0; i < plane.Length; i++)
        {
            if (plane[i].activeSelf)
            {
                plane[i].SetActive(false);
                count = i;
                break;
            }
        }

        count += direction;

        if (count >= plane.Length)
        {
            count = 0;
        }

        if (count < 0)
        {
            count = plane.Length - 1;
        }
        plane[count].SetActive(true);
    }
}
