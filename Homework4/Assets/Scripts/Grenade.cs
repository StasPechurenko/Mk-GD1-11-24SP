using UnityEngine;

public class Grenade : Bullet
{
    public float explosionRadius = 5f;
    public float explosionForce = 1000f;
    
    protected override void OnCollisionEnter(Collision collision)
    {
        Explode();
        base.OnCollisionEnter(collision);
    }

    private void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);               
            }
        }
    }
}
