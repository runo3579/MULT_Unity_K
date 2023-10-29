using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public GameObject spawnPoint; 
    private bool spawnedOnce = false;

    void Start()
    {
        if (!spawnedOnce)
        {
            for (int i = 0; i < 10; i++)
            {
                GameObject lamp = Instantiate(prefab, new Vector3(-1, 0, -5), Quaternion.Euler(0, 90, 0)); // Rotate by 90 degrees around the Y-axis
                lamp.transform.parent = spawnPoint.transform;
            }
            spawnedOnce = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LineUpPrefabs();
        }
    }

    void LineUpPrefabs()
    {
        GameObject[] lamps = new GameObject[spawnPoint.transform.childCount];
        for (int i = 0; i < lamps.Length; i++)
        {
            lamps[i] = spawnPoint.transform.GetChild(i).gameObject;
        }
        int numberOfLamps = lamps.Length;
        float distanceBetweenLamps = 2.0f;
        Vector3 startPosition = spawnPoint.transform.position - (numberOfLamps - 1) * distanceBetweenLamps / 2 * spawnPoint.transform.right;
        for (int i = 0; i < numberOfLamps; i++)
        {
            lamps[i].transform.position = startPosition + i * distanceBetweenLamps * spawnPoint.transform.right;
        }
    }
}