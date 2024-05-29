using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTrigger : MonoBehaviour
{
    public float hight = 4f;
    private Vector3 position; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            position = other.transform.position;
            position += new Vector3(0f, hight, 0f);
            other.transform.position = position;
        }
    }
}
