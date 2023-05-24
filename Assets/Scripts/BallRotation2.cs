using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation2 : MonoBehaviour
{
    public GameObject sphere;
    
    void Start()
    {
    }

    void Update()
    {
        transform.LookAt(sphere.transform);
    }
}
