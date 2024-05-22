using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected virtual void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
