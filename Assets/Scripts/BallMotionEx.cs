using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotionEx : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // Updateの間の移動量を計算
        //transform.Translate(new Vector3(5.0f, 1.5f, 0) * Time.deltaTime);

        // スタートしてからの経過時間に応じて初期位置からの移動量を計算
        transform.position = new Vector3(-10, 0, 0)
                    + new Vector3(5.0f, 1.5f, 0) * Time.time;
    }
}
