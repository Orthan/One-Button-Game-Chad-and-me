using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeatZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // V�rifie si l'objet en collision a un Rigidbody attach�, ce qui signifie qu'il est en mouvement et pourrait �tre un joueur
        if (other.attachedRigidbody != null)
        {
            // Recharge la sc�ne actuelle
            ReloadScene();
        }
    }

    // M�thode pour recharger la sc�ne actuelle
    private void ReloadScene()
    {
        // R�cup�re le nom de la sc�ne actuelle
        string sceneName = SceneManager.GetActiveScene().name;

        // Recharge la sc�ne actuelle
        SceneManager.LoadScene("Game Over");
    }


}
