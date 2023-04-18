using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GenesManager : MonoBehaviour
{
    public List<float> genesList;  // List.AddRange(array[]) to add an array to a list
    public float[] genesArray;

    // This works, but I should probably use a dictionary, it would be easier to use. It would be slower though, so I don't really know.

    public void InitializeGenes()
    {   // Initialize each set of genes with random values
        genesList.Clear();

        genesList.AddRange(RndColor(128, 255));
        genesList.Add(SizeMultiplier(0.5f, 2));
        // Other genes will be added

        // Store in an array to improve performance when getting values 
        genesArray = genesList.ToArray();
    }

    private float[] RndColor(float lowLimit, float highLimit)
    {   // Generates the color
        float r = UnityEngine.Random.Range(lowLimit, highLimit + 1)/255;
        float g = UnityEngine.Random.Range(lowLimit, highLimit + 1)/255;
        float b = UnityEngine.Random.Range(lowLimit, highLimit + 1)/255;
        float[] rgb = {r, g, b};
        return rgb;
    }

    private float SizeMultiplier(float lowLimit, float highLimit)
    {   // Sets the size of the creature
        // Code to generate random size.
        return 1;
    }
}
