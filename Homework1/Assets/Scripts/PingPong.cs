using UnityEngine;

public class PingPong : MonoBehaviour
{
    public Vector3 direction = new(1.0f, 0.0f, 0.0f);
    public float speed = 15.0f;
    private Vector3 startPosition = new Vector3(-10.0f, 0.0f, 0.0f);
    private float xSize = 10.0f;

    void Start()
    {
        transform.localPosition = startPosition;
    }

    void Update()
    {
        if (transform.position.x >= xSize)
        {
            transform.localPosition = -startPosition;
            direction = -direction;
        }
        else if (transform.position.x <= -xSize)
        {
            transform.localPosition = startPosition;
            direction = -direction;
        }

        float parabolaTrajectory = transform.position.x * transform.position.x / 100.0f;
        direction.y = parabolaTrajectory;

        if (direction.x > 0 && transform.position.x > 0 || direction.x < 0 && transform.position.x < 0)
        {
            direction.y = -direction.y;
        }

        transform.Translate(speed * Time.deltaTime * direction);
    }
}