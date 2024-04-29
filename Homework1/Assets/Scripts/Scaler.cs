using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 direction = new(1.0f, 1.0f, 1.0f);
    public float speed = 1.0f;

    void Start()
    {
        transform.Translate(0.0f, 5.0f, 0.0f);
    }

    void Update()
    {
        if (transform.localScale.x < 5.0f || transform.localScale.y < 5.0f || transform.localScale.y < 5.0f)
        {
            transform.localScale += speed * Time.deltaTime * direction;
        }
    }
}
