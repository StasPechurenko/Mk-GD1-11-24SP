using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 direction = new Vector3(1.0f, 2.0f, 3.0f);
    private float speed = 0.1f;

    void Start()
    {
        transform.Translate(0.0f, 3.0f, 0.0f);
    }

    void Update()
    {
        transform.Rotate(direction * speed);
    }
}