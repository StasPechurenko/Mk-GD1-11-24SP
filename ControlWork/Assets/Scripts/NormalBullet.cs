using UnityEngine;

public class NormalBullet : Bullet
{
    public Material[] material;
    public MeshRenderer sparrows;
    int random;
    protected  void OnCollisionEnter(Collision collision)
    {
        random = Random.Range(0, material.Length);
        ChangeMaterial();
    }

    public void ChangeMaterial()
    {
        sparrows.material = material[random];
    }

}
