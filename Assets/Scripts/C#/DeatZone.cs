using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeatZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si l'objet en collision a un Rigidbody attaché, ce qui signifie qu'il est en mouvement et pourrait être un joueur
        if (other.attachedRigidbody != null)
        {
            // Recharge la scène actuelle
            ReloadScene();
        }
    }

    // Méthode pour recharger la scène actuelle
    private void ReloadScene()
    {
        // Récupère le nom de la scène actuelle
        string sceneName = SceneManager.GetActiveScene().name;

        // Recharge la scène actuelle
        SceneManager.LoadScene("Game Over");
    }


}
