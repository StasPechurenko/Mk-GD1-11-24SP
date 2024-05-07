using UnityEngine;

public class SpawnPrefabs : MonoBehaviour
{
    public GameObject[] prefab;
    private GameObject instatnce;
    private Vector3 startPosition = new(0.0f, 0.0f, 0.0f);

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (prefab == null)
            {
                Debug.LogError("Prefab is NULL!!!");
                return;
            }

            if (instatnce != null)
            {
                Destroy(instatnce);
            }

            var rotation = Quaternion.identity;
            var position = startPosition;

            instatnce = Instantiate(prefab[Random.Range(0, prefab.Length)], position, rotation);
        }
    }
}