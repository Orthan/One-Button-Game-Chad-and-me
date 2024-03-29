using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooMuchSpeed : MonoBehaviour
{
    public float initialSpeed = 5f; // Vitesse initiale de la balle
    public float maxSpeed = 20f; // Vitesse maximale de la balle
    public float accelerationRate = 0.1f; // Taux d'accélération de la balle

    private float currentSpeed; // Vitesse actuelle de la balle

    void Start()
    {
        currentSpeed = initialSpeed; // Initialiser la vitesse actuelle
    }

    void Update()
    {
        // Augmenter la vitesse progressivement jusqu'à la vitesse maximale
        if (currentSpeed < maxSpeed)
        {
            currentSpeed += accelerationRate * Time.deltaTime;
        }

        // Déplacer la balle dans la direction de sa rotation
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }
}
