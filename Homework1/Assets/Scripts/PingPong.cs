using UnityEngine;

public class PingPong : MonoBehaviour
{
    public Vector3 direction = new(1.0f, 0.0f, 0.0f);
    public float speed = 1.0f;

    void Start()
    {
        transform.localPosition = new(-10.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        if (transform.position.x >= 10.0f)
        {
            transform.localPosition = new(10.0f, 0.0f, 0.0f);
            direction = -direction;
        }
        else if (transform.position.x <= -10.0f)
        {
            transform.localPosition = new(-10.0f, 0.0f, 0.0f);
            direction = -direction;
        }

        direction.y = transform.position.x * transform.position.x / 100.0f;

        if (direction.x > 0 && transform.position.x > 0 || direction.x < 0 && transform.position.x < 0)
        {
            direction.y = -direction.y;
        }

        transform.Translate(speed * Time.deltaTime * direction);
    }
}