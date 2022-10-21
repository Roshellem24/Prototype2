using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpawnRandomAnimal", startDelay, spawnInterval);
    }
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            //randomly generate animal index and spawn position//
            SpawnRandomAnimal ();

            void SpawnRandomAnimal() {
                int animalIndex = Random.Range(0, animalPrefabs.Length);
                Vector3 spawnos = new Vector3(Random.Range (-spawnRangeX, spawnRangeX), 0, spawnPosZ);
                 Instantiate(animalPrefabs[animalIndex], new = Vector3(0, 0 , 20) spawnpos, animalPrefabs[animalIndex].transform.rotation);
            }
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
                int animalIndex = Random.Range(0,animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
