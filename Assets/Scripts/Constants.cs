using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants
{
    public static float[] limits =
    {
        0.5f, 10,           //0 Size
        0, 1,               //1 ShieldingPercentage
        128, 255,           //3 ColorR
        128, 255,           //4 ColorG
        128, 255,           //5 ColorB
        0, 1,               //6 GenesMutationsProbabilty
        0, 1,               //7 BrainMutationsProbabilty
        60, 300,            //8 MaturityAge
        360, 600,           //9 OldnessAge
        0, 1,               //10 MaxExtraEnergyStoragePercentage
        0, 5,               //12 EnergyProductionEfficiencyPercentage
        0, Mathf.PI,        //14 RotationSpeedMultiplier
        0, 5,               //15 TranslationSpeedMultiplier
        0, 5,               //17 SmellSensitivityThresholdPhero1
        0, 5,               //19 SmellSensitivityThresholdPhero2
        0, 5,               //21 SmellSensitivityThresholdPhero3
        0, 30,              //26 SecretionRadius
        0, 2 * Mathf.PI,    //29 FOVAngle
        0, 5,               //30 FOVRadius
        0, 25,              //31 SightClarity
        0, 5                //33 CollisionSensitivityThreshold
    };

    public static float mutationStrength = 0.1f;
}