using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text timerText; // Référence au texte du timer
    public float totalTime = 60f; // Temps total du timer en secondes

    private float currentTime; // Temps actuel du timer
    private bool timerRunning = false; // Indicateur pour savoir si le timer est en cours

    void Start()
    {
        currentTime = totalTime; // Initialiser le temps actuel avec le temps total
        UpdateTimerDisplay(); // Mettre à jour l'affichage du timer
    }

    void Update()
    {
        if (timerRunning)
        {
            // Réduire le temps actuel du timer
            currentTime -= Time.deltaTime;

            // Vérifier si le temps est écoulé
            if (currentTime <= 0f)
            {
                currentTime = 0f; // Assurer que le temps restant ne devient pas négatif
                timerRunning = false; // Arrêter le timer
                Debug.Log("Le temps est écoulé !");
            }

            // Mettre à jour l'affichage du timer
            UpdateTimerDisplay();
        }
    }

    // Mettre à jour l'affichage du timer
    void UpdateTimerDisplay()
    {
        // Convertir le temps restant en minutes et secondes
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);

        // Mettre à jour le texte du timer dans le Canvas
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Fonction pour démarrer ou arrêter le timer
    public void ToggleTimer()
    {
        timerRunning = !timerRunning;
    }
}
