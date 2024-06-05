using UnityEngine;
using UnityEngine.InputSystem;

public class RobotController : MonoBehaviour
{
    public GameObject normalBulletPrefab;
    public GameObject grenadePrefab;
    public GameObject tennisBallPrefab;
    public Transform shootPoint;
    private int rand;
    public float shootForce = 20f;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bulletPrefab = null;

        rand = Random.Range(0, 4);

        switch (rand)
        {
            case 0:
                bulletPrefab = normalBulletPrefab;
                break;
            case 1:
                bulletPrefab = grenadePrefab;
                break;
            case 2:
                bulletPrefab = tennisBallPrefab;
                break;
        }

        if (bulletPrefab != null)
        {
            shootPoint.localEulerAngles = new Vector3(Random.Range(-180f, 180f), Random.Range(-180f, 180f), Random.Range(-180f, 180f));
            GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode.Impulse);
        }
    }
}
