using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotationEx : MonoBehaviour
{
    public GameObject plane;

    // 初期状態での平面中心から立方体中心への距離
    float kyori;
    void Start()
    {
        kyori = (transform.position - plane.transform.position).magnitude;
    }

    void Update()
    {
        // 同じ回転をする＝回転量を代入
        transform.eulerAngles = plane.transform.eulerAngles;

        Vector3 up = Vector3.up;
        up = transform.TransformDirection(up);

        // 平面の中心位置から平面の直上方向に進んだ先に立方体は位置する
        transform.position = plane.transform.position + up * kyori;
    }
}
