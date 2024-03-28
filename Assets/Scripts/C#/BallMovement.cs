using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public float _speed;


    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * _speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            _speed = 0;
        }

        //if (other.CompareTag("Trap2"))
        //{
        //    Destroy(gameObject);
        //    SceneManager.LoadScene("Game Over 2");
        //}
    }
}
