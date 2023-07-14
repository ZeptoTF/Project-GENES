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

    public void InitializeGenes(float[] genes, float mutationProbability, float mutationStrength)
    {   // Initialize each set of genes with random values
        genesList.Clear();

        genesList.Add(Size(genes[0], mutationProbability, mutationStrength));
        genesList.Add(ShieldPercentage(genes[1], mutationProbability, mutationStrength));
        genesList.Add(Mass());
        genesList.Add(ColorR(genes[3], mutationProbability, mutationStrength));
        genesList.Add(ColorG(genes[4], mutationProbability, mutationStrength));
        genesList.Add(ColorB(genes[5], mutationProbability, mutationStrength));
        genesList.Add(GenesMutationsProbabilty(genes[6], mutationProbability, mutationStrength));
        genesList.Add(BrainMutationsProbabilty(genes[7], mutationProbability, mutationStrength));
        genesList.Add(MaturityAge(genes[8], mutationProbability, mutationStrength));
        genesList.Add(OldnessAge(genes[9], mutationProbability, mutationStrength));
        genesList.Add(MaxExtraEnergyStoragePercentage(genes[10], mutationProbability, mutationStrength));
        genesList.Add(CanProduceEnergy(genes[11], mutationProbability));
        genesList.Add(EnergyProductionEfficiencyPercentage(genes[12], mutationProbability, mutationStrength));
        genesList.Add(CanMove(genes[13], mutationProbability));
        genesList.Add(RotationSpeedMultiplier(genes[14], mutationProbability, mutationStrength));
        genesList.Add(TranslationSpeedMultiplier(genes[15], mutationProbability, mutationStrength));
        genesList.Add(CanSmellPhero1(genes[16], mutationProbability));
        genesList.Add(SmellSensitivityThresholdPhero1(genes[17], mutationProbability, mutationStrength));
        genesList.Add(CanSmellPhero2(genes[18], mutationProbability));
        genesList.Add(SmellSensitivityThresholdPhero2(genes[19], mutationProbability, mutationStrength));
        genesList.Add(CanSmellPhero3(genes[20], mutationProbability));
        genesList.Add(SmellSensitivityThresholdPhero3(genes[21], mutationProbability, mutationStrength));
        genesList.Add(CanSecretePhero1(genes[22], mutationProbability));
        genesList.Add(CanSecretePhero2(genes[23], mutationProbability));
        genesList.Add(CanSecretePhero3(genes[24], mutationProbability));
        genesList.Add(CanSecretePoison(genes[25], mutationProbability));
        genesList.Add(SecretionRadius(genes[26], mutationProbability, mutationStrength));
        genesList.Add(CanSeeDistance(genes[27], mutationProbability));
        genesList.Add(CanSeeColor(genes[28], mutationProbability));
        genesList.Add(FOVAngle(genes[29], mutationProbability, mutationStrength));
        genesList.Add(FOVRadius(genes[30], mutationProbability, mutationStrength));
        genesList.Add(SightClarity(genes[31], mutationProbability, mutationStrength));
        genesList.Add(CanFeelCollision(genes[32], mutationProbability));
        genesList.Add(CollisionSensitivityThreshold(genes[33], mutationProbability, mutationStrength));
        // Technically all genes have been added

        // Store in an array to (possibly) improve performance when getting values  
        genesArray = genesList.ToArray();
    }

    private float Size(float parentValue, float mutationProbability, float mutationStrength)
    {   // Sets the size of the creature
        if (UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
        }
        return parentValue;
    }

    private float ShieldPercentage(float parentValue, float mutationProbability, float mutationStrength)
    {   // Sets the percentage of damage reduction
        if (UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
        }
        return parentValue;
    }

    private float Mass()
    {
        return (float)(genesList[0] * genesList[0] * 0.25 * MathF.PI * (1 + genesList[1]));
    }

    private float ColorR(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
        }
        return parentValue;
    }

    private float ColorG(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
        }
        return parentValue;
    }

    private float ColorB(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
        }
        return parentValue;
    }

    private float GenesMutationsProbabilty(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
        }
        return parentValue;
    }

    private float BrainMutationsProbabilty(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
        }
        return parentValue;
    }

    private float MaturityAge(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
        }
        return parentValue;
    }

    private float OldnessAge(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
        }
        return parentValue;
    }

    private float MaxExtraEnergyStoragePercentage(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
        }
        return parentValue;
    }

    private float CanProduceEnergy(float parentValue, float mutationProbability)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            if (parentValue == 1)
                return 0;
            else
                return 1;
        }
        return parentValue;
    }

    private float EnergyProductionEfficiencyPercentage(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (genesList[11] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            return parentValue;
        }
        else
        {
            return -1;
        }
    }

    private float CanMove(float parentValue, float mutationProbability)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            if (parentValue == 1)
                return 0;
            else
                return 1;
        }
        return parentValue;
    }

    private float RotationSpeedMultiplier(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (genesList[13] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            return parentValue;
        }
        else
        {
            return -1;
        }
    }

    private float TranslationSpeedMultiplier(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (genesList[13] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            return parentValue;
        }
        else
        {
            return -1;
        }
    }

    private float CanSmellPhero1(float parentValue, float mutationProbability)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            if (parentValue == 1)
                return 0;
            else
                return 1;
        }
        return parentValue;
    }

    private float SmellSensitivityThresholdPhero1(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (genesList[16] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            return parentValue;
        }
        else
        {
            return -1;
        }
    }

    private float CanSmellPhero2(float parentValue, float mutationProbability)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            if (parentValue == 1)
                return 0;
            else
                return 1;
        }
        return parentValue;
    }

    private float SmellSensitivityThresholdPhero2(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (genesList[18] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            return parentValue;
        }
        else
        {
            return -1;
        }
    }

    private float CanSmellPhero3(float parentValue, float mutationProbability)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            if (parentValue == 1)
                return 0;
            else
                return 1;
        }
        return parentValue;
    }

    private float SmellSensitivityThresholdPhero3(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (genesList[20] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            return parentValue;
        }
        else
        {
            return -1;
        }
    }

    private float CanSecretePhero1(float parentValue, float mutationProbability)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            if (parentValue == 1)
                return 0;
            else
                return 1;
        }
        return parentValue;
    }

    private float CanSecretePhero2(float parentValue, float mutationProbability)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            if (parentValue == 1)
                return 0;
            else
                return 1;
        }
        return parentValue;
    }

    private float CanSecretePhero3(float parentValue, float mutationProbability)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            if (parentValue == 1)
                return 0;
            else
                return 1;
        }
        return parentValue;
    }

    private float CanSecretePoison(float parentValue, float mutationProbability)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            if (parentValue == 1)
                return 0;
            else
                return 1;
        }
        return parentValue;
    }

    private float SecretionRadius(float parentValue, float mutationProbability, float mutationStrength)
    {
        if ((genesList[22] == 1 || genesList[23] == 1 || genesList[24] == 1 || genesList[25] == 1) && UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            return parentValue;
        }
        else
        {
            return -1;
        }
    }

    private float CanSeeDistance(float parentValue, float mutationProbability)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            if (parentValue == 1)
                return 0;
            else
                return 1;
        }
        return parentValue;
    }

    private float CanSeeColor(float parentValue, float mutationProbability)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            if (parentValue == 1)
                return 0;
            else
                return 1;
        }
        return parentValue;
    }

    private float FOVAngle(float parentValue, float mutationProbability, float mutationStrength)
    {
        if ((genesList[27] == 1 || genesList[28] == 1) && UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            return parentValue;
        }
        else
        {
            return -1;
        }
    }

    private float FOVRadius(float parentValue, float mutationProbability, float mutationStrength)
    {
        if ((genesList[27] == 1 || genesList[28] == 1) && UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            return parentValue;
        }
        else
        {
            return -1;
        }
    }

    private float SightClarity(float parentValue, float mutationProbability, float mutationStrength)
    {   // How many rays are casted in the fov.
        if ((genesList[27] == 1 || genesList[28] == 1) && UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            return parentValue;
        }
        else
        {
            return -1;
        }
    }

    private float CanFeelCollision(float parentValue, float mutationProbability)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            if (parentValue == 1)
                return 0;
            else
                return 1;
        }
        return parentValue;
    }

    private float CollisionSensitivityThreshold(float parentValue, float mutationProbability, float mutationStrength)
    {
        if (genesList[32] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            parentValue *= UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            return parentValue;
        }
        else
        {
            return -1;
        }
    }
}