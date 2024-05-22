using UnityEngine;
using UnityEngine.InputSystem;

public class RobotController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;
    public float rotateMouseSpeed = 5f;
    public GameObject normalBulletPrefab;
    public GameObject grenadePrefab;
    public GameObject tennisBallPrefab;
    public Transform shootPoint;
    public float shootForce = 20f;
    public InputActionReference movement;
    public InputActionReference look;
    Rigidbody body;

    private BulletType currentBulletType = BulletType.Normal;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Move()
    {
        var moveRobot = movement.action.ReadValue<Vector2>()*moveSpeed*Time.deltaTime;
        var rotateRobot = movement.action.ReadValue<Vector2>() * rotateSpeed * Time.deltaTime;
        var rotateHit = look.action.ReadValue<Vector2>()*rotateMouseSpeed*Time.deltaTime;

       
        body.AddForce(transform.forward * moveRobot.y, ForceMode.Impulse);
        transform.Rotate(0, rotateRobot.x, 0);
        shootPoint.Rotate(rotateHit.y, 0, 0 );

    }

    public void SetBulletType(BulletType bulletType)
    {
        currentBulletType = bulletType;
    }

    private void Shoot()
    {
        GameObject bulletPrefab = null;

        switch (currentBulletType)
        {
            case BulletType.Normal:
                bulletPrefab = normalBulletPrefab;
                break;
            case BulletType.Grenade:
                bulletPrefab = grenadePrefab;
                break;
            case BulletType.TennisBall:
                bulletPrefab = tennisBallPrefab;
                break;
        }

        if (bulletPrefab != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(shootPoint.forward * shootForce, ForceMode.Impulse);

            Destroy(bullet, 5f);
        }
    }
}
