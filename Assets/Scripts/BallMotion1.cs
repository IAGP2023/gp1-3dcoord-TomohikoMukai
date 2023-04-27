using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion1 : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        // Pattern 1.
        //*
        transform.Translate(Vector3.right * Time.deltaTime);
        //*/

        // Pattern 2.
        /*
        Vector3 move = new Vector3(Time.deltaTime, 0, 0);
        transform.Translate(move);
        //*/

        // Pattern 3.
        /*
        Vector3 move = new Vector3(Time.deltaTime, 0, 0);
        transform.position += move;
        //*/

        // Pattern 4.
        /*
        Vector3 p = transform.position;
        p.x = p.x + Time.deltaTime; // p.x += Time.deltaTime;
        transform.position = p;
        //*/


        // おまけ (Patten 改2)
        /*
        var move = new Vector3(Time.deltaTime, 0, 0);
        transform.Translate(move);        
        //*/
    }
}
