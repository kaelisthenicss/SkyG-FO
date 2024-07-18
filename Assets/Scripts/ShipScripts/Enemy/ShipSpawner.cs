using System.Collections;
using UnityEngine;

public class ShipSpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 6f;
    [SerializeField] private GameObject[] shipPrefabs;
    [SerializeField] private bool canSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);
        while (canSpawn)
        {
            yield return wait;
            int rand = Random.Range(0, shipPrefabs.Length);
            GameObject shipToSpawn = shipPrefabs[rand];

            GameObject spawnedShip = Instantiate(shipToSpawn, transform.position, Quaternion.identity);
        }
    }
}