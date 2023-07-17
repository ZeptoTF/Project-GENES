using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DefaultGenesManager : MonoBehaviour
{
    public List<float> genesList;  // List.AddRange(array[]) to add an array to a list
    public float[] genesArray;
    private float[] limits = Constants.limits;

    // I tried to use dictionaries. It didn't work. Maybe I'll try again in the future.

    public void InitializeGenes()
    {   // Initialize each set of genes with random values
        genesList.Clear();

        genesList.Add(1);                                                               //0
        genesList.Add(RndShieldPercentage(limits[2], limits[3]));
        genesList.Add(Mass());
        genesList.Add(RndColorR(limits[4], limits[5]));
        genesList.Add(RndColorG(limits[6], limits[7]));
        genesList.Add(RndColorB(limits[8], limits[9]));                                 //5
        genesList.Add(0.5f);
        genesList.Add(0.05f);
        genesList.Add(MaturityAge(limits[14], limits[15]));
        genesList.Add(OldnessAge(limits[16], limits[17]));
        genesList.Add(0);                                                               //10
        genesList.Add(0);
        genesList.Add(EnergyProductionEfficiencyPercentage(limits[20], limits[21]));
        genesList.Add(0);
        genesList.Add(RotationSpeedMultiplier(limits[22], limits[23]));
        genesList.Add(TranslationSpeedMultiplier(limits[24], limits[25]));              //15
        genesList.Add(0);
        genesList.Add(SmellSensitivityThresholdPhero1(limits[26], limits[27]));
        genesList.Add(0);
        genesList.Add(SmellSensitivityThresholdPhero2(limits[28], limits[29]));
        genesList.Add(0);                                                               //20
        genesList.Add(SmellSensitivityThresholdPhero3(limits[30], limits[31]));
        genesList.Add(0);
        genesList.Add(0);
        genesList.Add(0);
        genesList.Add(0);                                                               //25
        genesList.Add(SecretionRadius(0, 3 * genesList[0]));
        genesList.Add(0);
        genesList.Add(0);
        genesList.Add(FOVAngle(limits[34], limits[35]));
        genesList.Add(FOVRadius(limits[36], limits[37]));                               //30
        genesList.Add(SightClarity(limits[38], limits[39]));
        genesList.Add(0);
        genesList.Add(CollisionSensitivityThreshold(limits[40], limits[41]));           //33
        // Technically all genes have been added

        // Store in an array to (possibly) improve performance when getting values  
        genesArray = genesList.ToArray();
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
