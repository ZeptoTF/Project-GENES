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

        genesList.Add(RndSize(0.5f, 1.25f));
        genesList.Add(RndShieldPercentage(0, 1));
        genesList.Add(RndColorR(128, 255));
        genesList.Add(RndColorG(128, 255));
        genesList.Add(RndColorB(128, 255));
        genesList.Add(AgeingFactor(0, 5));
        genesList.Add(MaturityAge(0, 200));
        genesList.Add(OldnessAge(0, 500));
        genesList.Add(MaxExtraEnergyStoragePercentage(0, 1));
        genesList.AddRange(SmellingEnergy(0, 1, 0, 5));
        genesList.AddRange(ProducingEnergy(0, 1, 0, 5));
        // Other genes will be added

        // Store in an array to (possibly) improve performance when getting values 
        genesArray = genesList.ToArray();
    }

    private float RndSize(float lowLimit, float highLimit)
    {   // Sets the size of the creature
        float size = UnityEngine.Random.Range(lowLimit, highLimit);
        return size;
    }

    private float RndShieldPercentage(float lowLimit, float highLimit)
    {   // Sets the percentage of damage reduction
        float shielding = UnityEngine.Random.Range(lowLimit, highLimit);
        return shielding;
    }

    private float RndColorR(float lowLimit, float highLimit)
    {   // Generates the colorR
        float r = UnityEngine.Random.Range(lowLimit, highLimit) / 255;
        return r;
    }

    private float RndColorG(float lowLimit, float highLimit)
    {   // Generates the colorG
        float g = UnityEngine.Random.Range(lowLimit, highLimit) / 255;
        return g;
    }

    private float RndColorB(float lowLimit, float highLimit)
    {   // Generates the colorB
        float b = UnityEngine.Random.Range(lowLimit, highLimit) / 255;
        return b;
    }

    private float GeneMutationsProbabilty(float lowLimit, float highLimit)
    {
        float geneMutationProbabilty = UnityEngine.Random.Range(lowLimit, highLimit);
        return geneMutationProbabilty;
    }

    private float BrainMutationsProbabilty(float lowLimit, float highLimit)
    {
        float brainMutationProbabilty = UnityEngine.Random.Range(lowLimit, highLimit);
        return brainMutationProbabilty;
    }

    private float AgeingFactor(float lowLimit, float highLimit)
    {   // Sets the speed at which the creature ages
        float ageingFactor = UnityEngine.Random.Range(lowLimit, highLimit);
        return ageingFactor;
    }

    private float MaturityAge(float lowLimit, float highLimit)
    {
        float maturityAge = UnityEngine.Random.Range(lowLimit, highLimit);
        return maturityAge;
    }

    private float OldnessAge(float lowLimit, float highLimit)
    {
        float OldnessAge = UnityEngine.Random.Range(lowLimit, highLimit);
        return OldnessAge;
    }

    private float MaxExtraEnergyStoragePercentage(float lowLimit, float highLimit)
    {
        float maxExtraEnergyStorage = UnityEngine.Random.Range(lowLimit, highLimit);
        return maxExtraEnergyStorage;
    }

    private float[] SmellingEnergy(int lowLImitCSE, int highLimitCSE, float lowLimitESST, float highLimitESST)
    {
        float canSmellEnergy = UnityEngine.Random.Range(lowLImitCSE, highLimitCSE);
        float energySmellSensitivityThreshold;
        if (canSmellEnergy == 1)
        {
            energySmellSensitivityThreshold = UnityEngine.Random.Range(lowLimitESST, highLimitESST);
        }
        else
        {
            energySmellSensitivityThreshold = -1;
        }
        float[] smellingEnergy = { canSmellEnergy, energySmellSensitivityThreshold };
        return smellingEnergy;
    }

    private float[] ProducingEnergy(int lowLimitCPE, int highLimitCPE, float lowLimitEPEP, float highLimitEPEP)
    {
        float canProduceEnergy = UnityEngine.Random.Range(lowLimitCPE, highLimitCPE);
        float energyProductionEfficiencyPercentage;
        if (canProduceEnergy == 1)
        {
            energyProductionEfficiencyPercentage = UnityEngine.Random.Range(lowLimitEPEP, highLimitEPEP);
        }
        else
        {
            energyProductionEfficiencyPercentage = -1;
        }
        float[] producingEnergy = { canProduceEnergy, energyProductionEfficiencyPercentage };
        return producingEnergy;
    }

}
