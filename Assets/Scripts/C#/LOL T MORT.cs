using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LOLTMORT : MonoBehaviour
{
    public string sceneName;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadSceneAsync(3);
        }
    }
}
