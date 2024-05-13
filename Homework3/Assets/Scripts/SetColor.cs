using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    public Material material;
    public MeshRenderer[] sparrows;

    public void ChangeMaterial()
    {
        for (int i = 0; i < sparrows.Length; i++)
        {
            if (sparrows[i].gameObject.activeSelf)
            {
                sparrows[i].material = material;
                break;
            }
        }
    }
}