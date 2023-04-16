using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenesManager : MonoBehaviour
{
    public float[] genes;

    // Set the size of the genes array in the inspector
    [SerializeField] int numGenes = 3;

    public void InitializeGenes()
    {
        // Initialize the genes array with random values
        genes = new float[numGenes];
        for (int i = 0; i < numGenes; i++)
        {
            genes[i] = Random.Range(0f, 1f);
        }
    }
}
