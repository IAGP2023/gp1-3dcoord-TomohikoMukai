using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotationEx : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        Vector3 up = Vector3.up;
        up = transform.TransformDirection(up);
        Debug.Log(up);
    }
}
