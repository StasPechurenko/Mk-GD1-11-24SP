using UnityEngine;

public class Grenade : Bullet
{
    private bool isSecondColoision = false;


    protected void OnCollisionEnter(Collision collision)
    {
        Vector3 direction = new(1f, 1f, 1f);
        if (isSecondColoision)
        {
            direction = direction/2;
            isSecondColoision = false;
        }
        else
        {
            direction = direction*2;
            isSecondColoision = true;
        }
        transform.localScale = direction;
    }

}
