using UnityEngine;

public class TennisBall : Bullet
{
    protected  void OnCollisionEnter(Collision collision)
    {
        Vector3 direction = new(Random.Range(0.0f, 2.0f), Random.Range(0.0f, 2.0f), Random.Range(0.0f, 2.0f));

        transform.localScale = direction;
    }

}
