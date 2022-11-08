using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject fruitPrefab;
    public Transform[] spwawnPoints;

    public float minDelay = 0.1f;
    public float maxDelay = 1f;

    private void Start() 
    {
        StartCoroutine(SpawnFruits());
    }

    IEnumerator SpawnFruits()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(1f);

            int spawnIndex = Random.Range(0, spwawnPoints.Length);
            Transform spawnPoint = spwawnPoints[spawnIndex];

            GameObject spawnedFruit = Instantiate(fruitPrefab, spawnPoint.position, spawnPoint.rotation);
            Destroy(spawnedFruit, 5f);
        }
    }
}
