using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    float speed = 10;
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
