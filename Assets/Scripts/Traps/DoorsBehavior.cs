using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsBehavior : MonoBehaviour
{
    public GameObject FrontDoor;
    public GameObject BackDoor;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FrontDoor.SetActive(false);
            BackDoor.SetActive(true);
        }
    }
}
