using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 direction = new(1.0f, 1.0f, 1.0f);
    public float speed = 0.5f;

    void Start()
    {
        transform.localPosition = new(0.0f, 5.0f, 0.0f);
    }

    void Update()
    {
        if (transform.localScale.x < 3.0f || transform.localScale.y < 3.0f || transform.localScale.y < 3.0f)
        {
            transform.localScale += speed * Time.deltaTime * direction;
        }
    }
}
