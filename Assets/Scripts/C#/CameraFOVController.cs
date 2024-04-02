using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFOVController : MonoBehaviour
{
    public TooMuchSpeed ballSpeedScript; // R�f�rence au script de vitesse de la balle
    public Camera mainCamera; // R�f�rence � la cam�ra principale
    public float minFOV = 50f; // Champ de vision minimum
    public float maxFOV = 75f; // Champ de vision maximum
    public float fovIncreaseRate = 0.1f; // Taux d'augmentation du champ de vision

    public TooMuchSpeed tooMuchSpeed;

    void Update()
    {

        // R�cup�rer la vitesse actuelle de la balle depuis le script de vitesse
        float currentSpeed = ballSpeedScript.GetCurrentSpeed();

        // Calculer le nouvel angle de champ de vision en fonction de la vitesse
        float newFOV = mainCamera.fieldOfView + currentSpeed * fovIncreaseRate;

        // Limiter le champ de vision dans la plage sp�cifi�e
        newFOV = Mathf.Clamp(newFOV, minFOV, maxFOV);

        // Appliquer le nouvel angle de champ de vision � la cam�ra principale
        mainCamera.fieldOfView = newFOV;
    }
}
