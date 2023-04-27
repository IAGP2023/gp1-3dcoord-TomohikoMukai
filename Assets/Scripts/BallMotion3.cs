using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion3 : MonoBehaviour
{
    Vector3 velocity;
    Vector3 position;
    public float speed;

    void Start()
    {
        position.Set(0, 0, 0);
        velocity.Set(1.0f, 0, 1.0f);
        velocity *= speed / velocity.magnitude;
    }
    
    void Update()
    {
        position += velocity * Time.deltaTime;
        transform.position = position;
    }
}
  
