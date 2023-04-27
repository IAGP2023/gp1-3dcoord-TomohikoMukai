using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation1 : MonoBehaviour
{
    Vector3 angles;
    void Start()
    {
        angles = Vector3.zero;
    }
    void Update()
    {
        // Pattern 1.
        //*
        angles.x += 10.0f * Time.deltaTime;
        transform.eulerAngles = angles;
        //*/

        // Pattern 2.
        /*
        angles.Set(10.0f * Time.deltaTime, 0, 0);
        transform.Rotate(angles);
        //*/

        // Pattern 3.
        /*
        angles.x += 10.0f * Time.deltaTime;
        transform.rotation = Quaternion.Euler(angles);
        //*/

        //正常動作しないパターン
        /*
        var angles = transform.eulerAngles;
        angles.x += 10.0f * Time.deltaTime;
        transform.eulerAngles = angles;
        //*/
    }
}
