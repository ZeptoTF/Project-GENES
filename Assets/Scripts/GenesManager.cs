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

        genesList.Add(RndSize(0.5f, 1.25f));                        //0
        genesList.Add(RndShieldPercentage(0, 1));
        genesList.Add(Mass());
        genesList.Add(RndColorR(128, 255));
        genesList.Add(RndColorG(128, 255));
        genesList.Add(RndColorB(128, 255));                         //5
        genesList.Add(GenesMutationsProbabilty(0, 1));
        genesList.Add(BrainMutationsProbabilty(0, 1));
        genesList.Add(AgeingFactor(0, 5));
        genesList.Add(MaturityAge(0, 200));
        genesList.Add(OldnessAge(0, 500));                          //10
        genesList.Add(MaxExtraEnergyStoragePercentage(0, 1));
        genesList.Add(CanProduceEnergy(0, 1));
        genesList.Add(EnergyProductionEfficiencyPercentage(0, 5));
        genesList.Add(CanMove(0, 1));
        genesList.Add(RotationSpeedMultiplier(0, Mathf.PI));        //15
        genesList.Add(TranslationSpeedMultiplier(0, 5));
        genesList.Add(CanSmellPhero1(0, 1));
        genesList.Add(SmellSensitivityThresholdPhero1(0, 5));
        genesList.Add(CanSmellPhero2(0, 1));
        genesList.Add(SmellSensitivityThresholdPhero2(0, 5));       //20
        genesList.Add(CanSmellPhero3(0, 1));
        genesList.Add(SmellSensitivityThresholdPhero3(0, 5));
        genesList.Add(CanSmellPoison(0, 1));
        genesList.Add(SmellSensitivityThresholdPoison(0, 5));
        genesList.Add(CanSecretePhero1(0, 1));                      //25
        genesList.Add(CanSecretePhero2(0, 1));
        genesList.Add(CanSecretePhero3(0, 1));
        genesList.Add(CanSecretePoison(0, 1));
        genesList.Add(SecretionRadius(0, 3 * genesList[0]));
        genesList.Add(CanSeeDistance(0, 1));                        //30
        genesList.Add(CanSeeColor(0, 1));
        genesList.Add(FOVAngle(0, 2 * Mathf.PI));
        genesList.Add(FOVRadius(0, 5));
        genesList.Add(CanFeelCollision(0, 1));
        genesList.Add(CollisionSensitivityThreshold(0, 5));         //35
        // Technically all genes have been added

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

    private float Mass()
    {
        return (float)(genesList[0] * genesList[0] * 0.25 * MathF.PI * (1 + genesList[1]));
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

    private float GenesMutationsProbabilty(float lowLimit, float highLimit)
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

    private float CanProduceEnergy(int lowLimit, int highLimit)
    {
        float canProduceEnergy = UnityEngine.Random.Range(lowLimit, highLimit);
        return canProduceEnergy;
    }

    private float EnergyProductionEfficiencyPercentage(float lowLimit, float highLimit)
    {

        float energyProductionEfficiencyPercentage;
        if (genesList[12] == 1)
        {
            energyProductionEfficiencyPercentage = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            energyProductionEfficiencyPercentage = -1;
        }
        return energyProductionEfficiencyPercentage;
    }

    private float CanMove(int lowLimit, int highLimit)
    {
        float canMove = UnityEngine.Random.Range(lowLimit, highLimit);
        return canMove;
    }

    private float RotationSpeedMultiplier(float lowLimit, float highLimit)
    {

        float rotationSpeedMultiplier;
        if (genesList[14] == 1)
        {
            rotationSpeedMultiplier = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            rotationSpeedMultiplier = -1;
        }
        return rotationSpeedMultiplier;
    }

    private float TranslationSpeedMultiplier(float lowLimit, float highLimit)
    {
        float translationSpeedMultiplier;
        if (genesList[14] == 1)
        {
            translationSpeedMultiplier = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            translationSpeedMultiplier = -1;
        }
        return translationSpeedMultiplier;
    }

    private float CanSmellPhero1(int lowLimit, int highLimit)
    {
        float canSmellPhero1 = UnityEngine.Random.Range(lowLimit, highLimit);
        return canSmellPhero1;
    }

    private float SmellSensitivityThresholdPhero1(float lowLimit, float highLimit)
    {
        float smellSensitivityThresholdPhero1;
        if (genesList[17] == 1)
        {
            smellSensitivityThresholdPhero1 = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            smellSensitivityThresholdPhero1 = -1;
        }
        return smellSensitivityThresholdPhero1;
    }

    private float CanSmellPhero2(int lowLimit, int highLimit)
    {
        float canSmellPhero2 = UnityEngine.Random.Range(lowLimit, highLimit);
        return canSmellPhero2;
    }

    private float SmellSensitivityThresholdPhero2(float lowLimit, float highLimit)
    {
        float smellSensitivityThresholdPhero2;
        if (genesList[19] == 1)
        {
            smellSensitivityThresholdPhero2 = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            smellSensitivityThresholdPhero2 = -1;
        }
        return smellSensitivityThresholdPhero2;
    }

    private float CanSmellPhero3(int lowLimit, int highLimit)
    {
        float canSmellPhero3 = UnityEngine.Random.Range(lowLimit, highLimit);
        return canSmellPhero3;
    }

    private float SmellSensitivityThresholdPhero3(float lowLimit, float highLimit)
    {
        float smellSensitivityThresholdPhero3;
        if (genesList[21] == 1)
        {
            smellSensitivityThresholdPhero3 = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            smellSensitivityThresholdPhero3 = -1;
        }
        return smellSensitivityThresholdPhero3;
    }

    private float CanSmellPoison(int lowLimit, int highLimit)
    {
        float canSmellPoison = UnityEngine.Random.Range(lowLimit, highLimit);
        return canSmellPoison;
    }

    private float SmellSensitivityThresholdPoison(float lowLimit, float highLimit)
    {
        float smellSensitivityThresholdPoison;
        if (genesList[23] == 1)
        {
            smellSensitivityThresholdPoison = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            smellSensitivityThresholdPoison = -1;
        }
        return smellSensitivityThresholdPoison;
    }

    private float CanSecretePhero1(int lowLimit, int highLimit)
    {
        float canSecretePhero1 = UnityEngine.Random.Range(lowLimit, highLimit);
        return canSecretePhero1;
    }

    private float CanSecretePhero2(int lowLimit, int highLimit)
    {
        float canSecretePhero2 = UnityEngine.Random.Range(lowLimit, highLimit);
        return canSecretePhero2;
    }

    private float CanSecretePhero3(int lowLimit, int highLimit)
    {
        float canSecretePhero3 = UnityEngine.Random.Range(lowLimit, highLimit);
        return canSecretePhero3;
    }

    private float CanSecretePoison(int lowLimit, int highLimit)
    {
        float canSecretePoison = UnityEngine.Random.Range(lowLimit, highLimit);
        return canSecretePoison;
    }

    private float SecretionRadius(float lowLimit, float highLimit)
    {
        float secretionRadius;
        if (genesList[25] == 1 || genesList[26] == 1 || genesList[27] == 1 || genesList[28] == 1)
        {
            secretionRadius = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            secretionRadius = -1;
        }
        return secretionRadius;
    }

    private float CanSeeDistance(int lowLimit, int highLimit)
    {
        float canSeeDistance = UnityEngine.Random.Range(lowLimit, highLimit);
        return canSeeDistance;
    }

    private float CanSeeColor(int lowLimit, int highLimit)
    {
        float canSeeColor = UnityEngine.Random.Range(lowLimit, highLimit);
        return canSeeColor;
    }

    private float FOVAngle(float lowLimit, float highLimit)
    {
        float fovAngle;
        if (genesList[30] == 1 || genesList[31] == 1)
        {
            fovAngle = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            fovAngle = 0;
        }
        return fovAngle;
    }

    private float FOVRadius(float lowLimit, float highLimit)
    {
        float fovRadius;
        if (genesList[30] == 1 || genesList[31] == 1)
        {
            fovRadius = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            fovRadius = 0;
        }
        return fovRadius;
    }

    private float CanFeelCollision(int lowLimit, int highLimit)
    {
        float canFeelCollision = UnityEngine.Random.Range(lowLimit, highLimit);
        return canFeelCollision;
    }

    private float CollisionSensitivityThreshold(float lowLimit, float highLimit)
    {
        float collisionSensitivityThreshold;
        if (genesList[34] == 1)
        {
            collisionSensitivityThreshold = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            collisionSensitivityThreshold = -1;
        }
        return collisionSensitivityThreshold;
    }
}
