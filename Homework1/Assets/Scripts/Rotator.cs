using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 direction = new Vector3(5.0f, 5.0f, 5.0f);
    public float speed = 10.0f;

    void Start()
    {
        transform.localPosition = new(0.0f, 3.0f, 0.0f);
    }

    void Update()
    {
        transform.Rotate(direction * speed*Time.deltaTime);
    }
}