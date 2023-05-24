using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 p = Vector3.zero;
        p.x = 5.0f * Mathf.Sin(Time.time * 5.0f);
        p.y = 5.0f * Mathf.Cos(Time.time * 5.0f);
        transform.position = p;
        //*/

        // RotateAroundを使うパターン
        transform.RotateAround(Vector3.zero, Vector3.up, 60.0f * Time.deltaTime);
    }
}
