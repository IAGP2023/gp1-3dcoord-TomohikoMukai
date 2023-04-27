using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation2 : MonoBehaviour
{
    public Vector3 targetPosition;
    
    void Start()
    {
    }

    void Update()
    {
        transform.LookAt(targetPosition);
    }
}
