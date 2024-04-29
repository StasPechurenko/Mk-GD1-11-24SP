using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float time;

    void Update()
    {
        time += Time.deltaTime;

        if (time >= 1)
        {
            time = 0;
            transform.localPosition = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(0.0f, 10.0f), Random.Range(-5.0f, 5.0f));
        }
    }
}