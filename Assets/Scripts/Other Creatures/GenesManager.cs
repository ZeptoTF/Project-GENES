using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GenesManager : MonoBehaviour
{
    public List<float> genesList;  // List.AddRange(array[]) to add an array to a list
    public float[] genesArray;
    private float[] limits = Constants.limits;

    // I tried to use dictionaries. It didn't work. Maybe I'll try again in the future.

    public void InitializeGenes(float[] genes, float mutationStrength)
    {   // Initialize each set of genes with random values
        genesList.Clear();

        genesList.Add(Size(genes[0], genes[6], mutationStrength, limits[0], limits[1]));                                     //0
        genesList.Add(ShieldPercentage(genes[1], genes[6], mutationStrength, limits[2], limits[3]));
        genesList.Add(Mass());
        genesList.Add(ColorR(genes[3], genes[6], mutationStrength, limits[4], limits[5]));
        genesList.Add(ColorG(genes[4], genes[6], mutationStrength, limits[6], limits[7]));
        genesList.Add(ColorB(genes[5], genes[6], mutationStrength, limits[8], limits[9]));                                   //5
        genesList.Add(GenesMutationsProbabilty(genes[6], genes[6], mutationStrength, limits[10], limits[11]));
        genesList.Add(BrainMutationsProbabilty(genes[7], genes[6], mutationStrength, limits[12], limits[13]));
        genesList.Add(MaturityAge(genes[8], genes[6], mutationStrength, limits[14], limits[15]));
        genesList.Add(OldnessAge(genes[9], genes[6], mutationStrength, limits[16], limits[17]));
        genesList.Add(MaxExtraEnergyStoragePercentage(genes[10], genes[6], mutationStrength, limits[18], limits[19]));       //10
        genesList.Add(CanProduceEnergy(genes[11], genes[6]));
        genesList.Add(EnergyProductionEfficiencyPercentage(genes[12], genes[6], mutationStrength, limits[20], limits[21]));
        genesList.Add(CanMove(genes[13], genes[6]));
        genesList.Add(RotationSpeedMultiplier(genes[14], genes[6], mutationStrength, limits[22], limits[23]));
        genesList.Add(TranslationSpeedMultiplier(genes[15], genes[6], mutationStrength, limits[24], limits[25]));            //15
        genesList.Add(CanSmellPhero1(genes[16], genes[6]));
        genesList.Add(SmellSensitivityThresholdPhero1(genes[17], genes[6], mutationStrength, limits[26], limits[27]));
        genesList.Add(CanSmellPhero2(genes[18], genes[6]));
        genesList.Add(SmellSensitivityThresholdPhero2(genes[19], genes[6], mutationStrength, limits[28], limits[29]));
        genesList.Add(CanSmellPhero3(genes[20], genes[6]));                                                                  //20
        genesList.Add(SmellSensitivityThresholdPhero3(genes[21], genes[6], mutationStrength, limits[30], limits[31]));
        genesList.Add(CanSecretePhero1(genes[22], genes[6]));
        genesList.Add(CanSecretePhero2(genes[23], genes[6]));
        genesList.Add(CanSecretePhero3(genes[24], genes[6]));
        genesList.Add(CanSecretePoison(genes[25], genes[6]));                                                                //25
        genesList.Add(SecretionRadius(genes[26], genes[6], mutationStrength, limits[32], limits[33]));
        genesList.Add(CanSeeDistance(genes[27], genes[6]));
        genesList.Add(CanSeeColor(genes[28], genes[6]));
        genesList.Add(FOVAngle(genes[29], genes[6], mutationStrength, limits[34], limits[35]));
        genesList.Add(FOVRadius(genes[30], genes[6], mutationStrength, limits[36], limits[37]));                             //30
        genesList.Add(SightClarity(genes[31], genes[6], mutationStrength, limits[38], limits[39]));
        genesList.Add(CanFeelCollision(genes[32], genes[6]));
        genesList.Add(CollisionSensitivityThreshold(genes[33], genes[6], mutationStrength, limits[40], limits[41]));         //33
        // Technically all genes have been added

        // Store in an array to (possibly) improve performance when getting values  
        genesArray = genesList.ToArray();
    }

    private float Size(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {   // Sets the size of the creature
        if (UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        return parentValue;
    }

    private float ShieldPercentage(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {   // Sets the percentage of damage reduction
        if (UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        return parentValue;
    }

    private float Mass()
    {
        return (float)(genesList[0] * genesList[0] * 0.25 * MathF.PI * (1 + genesList[1]));
    }

    private float ColorR(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        return parentValue;
    }

    private float ColorG(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        return parentValue;
    }

    private float ColorB(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        return parentValue;
    }

    private float GenesMutationsProbabilty(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        return parentValue;
    }

    private float BrainMutationsProbabilty(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        return parentValue;
    }

    private float MaturityAge(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        return parentValue;
    }

    private float OldnessAge(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        return parentValue;
    }

    private float MaxExtraEnergyStoragePercentage(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
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

    private float EnergyProductionEfficiencyPercentage(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (genesList[11] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
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

    private float RotationSpeedMultiplier(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (genesList[13] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        else
        {
            return -1;
        }
    }

    private float TranslationSpeedMultiplier(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (genesList[13] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
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

    private float SmellSensitivityThresholdPhero1(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (genesList[16] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
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

    private float SmellSensitivityThresholdPhero2(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (genesList[18] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
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

    private float SmellSensitivityThresholdPhero3(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (genesList[20] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
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

    private float SecretionRadius(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if ((genesList[22] == 1 || genesList[23] == 1 || genesList[24] == 1 || genesList[25] == 1) && UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
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

    private float FOVAngle(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if ((genesList[27] == 1 || genesList[28] == 1) && UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        else
        {
            return -1;
        }
    }

    private float FOVRadius(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if ((genesList[27] == 1 || genesList[28] == 1) && UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        else
        {
            return -1;
        }
    }

    private float SightClarity(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {   // How many rays are casted in the fov.
        if ((genesList[27] == 1 || genesList[28] == 1) && UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
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

    private float CollisionSensitivityThreshold(float parentValue, float mutationProbability, float mutationStrength, float lowLimit, float highLimit)
    {
        if (genesList[32] == 1 && UnityEngine.Random.value <= mutationProbability)
        {
            float mutation = UnityEngine.Random.Range(1 - mutationStrength, 1 + mutationStrength);
            if (mutation * parentValue < lowLimit)
                return lowLimit;
            else if (mutation * parentValue > highLimit)
                return highLimit;
            else
                return parentValue * mutation;
        }
        else
        {
            return -1;
        }
    }
}