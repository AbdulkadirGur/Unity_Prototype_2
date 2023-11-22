using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    public float startDelay = 2.0f;
    public float spawnInterval = 1.5f;
   
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals",startDelay ,spawnInterval);
    }

   
    void Update()
    {
        
    }

    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 newSpawn = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], newSpawn, animalPrefabs[animalIndex].transform.rotation);
    }
}
