using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GenesManager : MonoBehaviour
{
    public List<float> genesList;  // List.AddRange(array[]) to add an array to a list
    public float[] genesArray;

    // I tried to use dictionaries. It didn't work. Maybe I'll try again in the future.

    public void InitializeGenes()
    {   // Initialize each set of genes with random values
        genesList.Clear();

        genesList.AddRange(RndColor(128, 255));
        genesList.AddRange(RndSize(0.75f, 1.25f));
        // Other genes will be added

        // Store in an array to (possibly) improve performance when getting values 
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

    private float[] RndSize(float lowLimit, float highLimit)
    {
        // Sets the size of the creature
        float width = UnityEngine.Random.Range(lowLimit, highLimit);
        float length = UnityEngine.Random.Range(lowLimit, highLimit);
        float[] size = {width, length };
        return size;
    }
}
