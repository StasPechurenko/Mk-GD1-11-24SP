using UnityEngine;

public class Scaler : MonoBehaviour
{
    public Vector3 direction = new(3.0f, 3.5f, 4.8f);
    public float speed = 0.5f;
    private Vector3 startPosition = new Vector3(0.0f, 5.0f, 0.0f);

    void Start()
    {
        transform.localPosition = startPosition;
    }

    void Update()
    {
            transform.localScale =Vector3.Lerp(transform.localScale,direction,speed*Time.deltaTime);       
    }
}
