using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float timeOut = 1.5f;
    private float time;

    void Update()
    {
        time += Time.deltaTime;

        if (time >= timeOut)
        {
            newPosition();
            time = 0;
        }
    }
    void newPosition()
    {
        transform.localPosition = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(0.0f, 10.0f), Random.Range(-5.0f, 5.0f));
    }
}