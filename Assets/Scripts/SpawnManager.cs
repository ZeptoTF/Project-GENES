using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject creaturePrefab; // Public variable for the creature prefab
    public int numberOfCreatures = 10; // Public variable for the number of creatures to spawn
    public Vector2 spawnArea = new Vector2(10, 10); // Active spawning area

    void Start()
    {
        SpawnCreatures(); // Call method to spawn creatures
    }

    void SpawnCreatures()
    {
        for (int i = 0; i < numberOfCreatures; i++)
        {
            // Call Genes script to initialize gene array with random values
            //creaturePrefab.GetComponent<GenesManager>().InitializeGenes();

            // Instantiate creature prefab and change mass
            GameObject clone;
            clone = Instantiate(creaturePrefab, RndSpawnLocation(), Quaternion.AngleAxis(Random.Range(0.0f, 360.0f), Vector3.forward));
            clone.GetComponent<GenesManager>().InitializeGenes();
            clone.GetComponent<Rigidbody2D>().mass = clone.GetComponent<GenesManager>().genesArray[2];
        }
    }

    private Vector2 RndSpawnLocation()
    {
        float x = Random.Range(-spawnArea.x / 2, spawnArea.x / 2);
        float y = Random.Range(-spawnArea.y / 2, spawnArea.y / 2);
        Vector2 spawnPosition = new Vector2(x, y);
        return spawnPosition;
    }

}
