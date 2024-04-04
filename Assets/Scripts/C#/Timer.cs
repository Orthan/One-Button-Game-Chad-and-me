using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text timerText; // R�f�rence au texte du timer
    public float totalTime = 60f; // Temps total du timer en secondes

    private float currentTime; // Temps actuel du timer
    private bool timerRunning = false; // Indicateur pour savoir si le timer est en cours

    void Start()
    {
        currentTime = totalTime; // Initialiser le temps actuel avec le temps total
        UpdateTimerDisplay(); // Mettre � jour l'affichage du timer
    }

    void Update()
    {
        if (timerRunning)
        {
            // R�duire le temps actuel du timer
            currentTime -= Time.deltaTime;

            // V�rifier si le temps est �coul�
            if (currentTime <= 0f)
            {
                currentTime = 0f; // Assurer que le temps restant ne devient pas n�gatif
                timerRunning = false; // Arr�ter le timer
                Debug.Log("Le temps est �coul� !");
            }

            // Mettre � jour l'affichage du timer
            UpdateTimerDisplay();
        }
    }

    // Mettre � jour l'affichage du timer
    void UpdateTimerDisplay()
    {
        // Convertir le temps restant en minutes et secondes
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);

        // Mettre � jour le texte du timer dans le Canvas
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Fonction pour d�marrer ou arr�ter le timer
    public void ToggleTimer()
    {
        timerRunning = !timerRunning;
    }
}
