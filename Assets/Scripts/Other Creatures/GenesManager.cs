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

        genesList.Add(Size(0.5f, 1.25f));                        //0
        genesList.Add(ShieldPercentage(0, 1));
        genesList.Add(Mass());
        genesList.Add(ColorR(128, 255));
        genesList.Add(ColorG(128, 255));
        genesList.Add(ColorB(128, 255));                         //5
        genesList.Add(GenesMutationsProbabilty(0, 1));
        genesList.Add(BrainMutationsProbabilty(0, 1));
        genesList.Add(MaturityAge(0, 200));
        genesList.Add(OldnessAge(0, 500));
        genesList.Add(MaxExtraEnergyStoragePercentage(0, 1));       //10
        genesList.Add(CanProduceEnergy(0, 1));
        genesList.Add(EnergyProductionEfficiencyPercentage(0, 5));
        genesList.Add(CanMove(0, 1));
        genesList.Add(RotationSpeedMultiplier(0, Mathf.PI));
        genesList.Add(TranslationSpeedMultiplier(0, 5));            //15
        genesList.Add(CanSmellPhero1(0, 1));
        genesList.Add(SmellSensitivityThresholdPhero1(0, 5));
        genesList.Add(CanSmellPhero2(0, 1));
        genesList.Add(SmellSensitivityThresholdPhero2(0, 5));
        genesList.Add(CanSmellPhero3(0, 1));                        //20
        genesList.Add(SmellSensitivityThresholdPhero3(0, 5));
        genesList.Add(CanSecretePhero1(0, 1));
        genesList.Add(CanSecretePhero2(0, 1));
        genesList.Add(CanSecretePhero3(0, 1));
        genesList.Add(CanSecretePoison(0, 1));                      //25
        genesList.Add(SecretionRadius(0, 3 * genesList[0]));
        genesList.Add(CanSeeDistance(0, 1));
        genesList.Add(CanSeeColor(0, 1));
        genesList.Add(FOVAngle(0, 2 * Mathf.PI));
        genesList.Add(FOVRadius(0, 5));                             //30
        genesList.Add(SightClarity(0, 25));
        genesList.Add(CanFeelCollision(0, 1));
        genesList.Add(CollisionSensitivityThreshold(0, 5));         //33
        // Technically all genes have been added

        // Store in an array to (possibly) improve performance when getting values  
        genesArray = genesList.ToArray();
    }

    private float Size(float lowLimit, float highLimit)
    {   // Sets the size of the creature
        float size = UnityEngine.Random.Range(lowLimit, highLimit);
        return size;
    }

    private float ShieldPercentage(float lowLimit, float highLimit)
    {   // Sets the percentage of damage reduction
        float shielding = UnityEngine.Random.Range(lowLimit, highLimit);
        return shielding;
    }

    private float Mass()
    {
        return (float)(genesList[0] * genesList[0] * 0.25 * MathF.PI * (1 + genesList[1]));
    }

    private float ColorR(float lowLimit, float highLimit)
    {   // Generates the colorR
        float r = UnityEngine.Random.Range(lowLimit, highLimit) / 255;
        return r;
    }

    private float ColorG(float lowLimit, float highLimit)
    {   // Generates the colorG
        float g = UnityEngine.Random.Range(lowLimit, highLimit) / 255;
        return g;
    }

    private float ColorB(float lowLimit, float highLimit)
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
        if (genesList[11] == 1)
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
        if (genesList[13] == 1)
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
        if (genesList[13] == 1)
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
        if (genesList[16] == 1)
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
        if (genesList[18] == 1)
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
        if (genesList[20] == 1)
        {
            smellSensitivityThresholdPhero3 = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            smellSensitivityThresholdPhero3 = -1;
        }
        return smellSensitivityThresholdPhero3;
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
        if (genesList[22] == 1 || genesList[23] == 1 || genesList[24] == 1 || genesList[25] == 1)
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
        if (genesList[27] == 1 || genesList[28] == 1)
        {
            fovAngle = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            fovAngle = -1;
        }
        return fovAngle;
    }

    private float FOVRadius(float lowLimit, float highLimit)
    {
        float fovRadius;
        if (genesList[27] == 1 || genesList[28] == 1)
        {
            fovRadius = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            fovRadius = -1;
        }
        return fovRadius;
    }

    private float SightClarity(float lowLimit, float highLimit)
    {   // How many rays are casted in the fov.
        float sightClarity;
        if (genesList[27] == 1 || genesList[28] == 1)
        {
            sightClarity = UnityEngine.Random.Range(lowLimit, highLimit);
        }
        else
        {
            sightClarity = -1;
        }
        return sightClarity;
    }

    private float CanFeelCollision(int lowLimit, int highLimit)
    {
        float canFeelCollision = UnityEngine.Random.Range(lowLimit, highLimit);
        return canFeelCollision;
    }

    private float CollisionSensitivityThreshold(float lowLimit, float highLimit)
    {
        float collisionSensitivityThreshold;
        if (genesList[32] == 1)
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
