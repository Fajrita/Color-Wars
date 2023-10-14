using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class BulletPool : MonoBehaviour
{
    public int bulletPoolSize = 10;
    public GameObject bullet; 

    [HideInInspector]
    public GameObject[] bullets;
    [HideInInspector]
    public int bulletNumber = -1;

    void Start()
    {
        bullets = new GameObject[bulletPoolSize];
        for (int i = 0; i < bulletPoolSize; i++)
        {
            bullets[i] = Instantiate(bullet, new Vector3(-10, -10f, -10f), Quaternion.identity);
        }
    }
}
