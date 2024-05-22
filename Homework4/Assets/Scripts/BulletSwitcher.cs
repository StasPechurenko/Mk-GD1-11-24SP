using UnityEngine;

public enum BulletType
{
    Normal,
    Grenade,
    TennisBall
}

public class BulletSwitcher : MonoBehaviour
{
    public BulletType bulletType;

    private void OnTriggerEnter(Collider other)
    {
            other.GetComponent<RobotController>().SetBulletType(bulletType);
    }
}
