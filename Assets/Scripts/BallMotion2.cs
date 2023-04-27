using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion2 : MonoBehaviour
{
    Vector3 position;
    Vector3 velocity;

    void Start()
    {
        // Pattern 1.
        //*
        velocity.x = 1.0f;
        velocity.y = 0;
        velocity.z = 0;
        //*/

        // Pattern 2.
        /*
        velocity = new Vector3(1.0f, 0, 0);
        //*/

        // Pattern 3.
        /*
        //velocity.Set(1.0f, 0, 0);
        //*/
    }

    void Update()
    {
        // Pattern 1.
        //*        
        position += velocity * Time.deltaTime;
        transform.position = position;
        //*/

        // Pattern 2.
        /*
        transform.position = position + velocity * Time.time;
        //*/
    }
}
