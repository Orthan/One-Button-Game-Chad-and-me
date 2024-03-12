using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
