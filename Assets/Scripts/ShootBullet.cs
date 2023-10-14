using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    private BulletPool pool;
    public Transform disp;

    [SerializeField]
    float shootingTime = 1;
    float shootingTimeCounter;
    void Start()
    {
        pool = GameObject.FindObjectOfType<BulletPool>();
    }

    void Update()
    {
        if (shootingTimeCounter > 0)
        {
            shootingTimeCounter -= Time.deltaTime;
        }
        if (pool.bulletNumber < 9)
        {
            if (shootingTimeCounter <= 0)
            {
                shootingTimeCounter = shootingTime;
                Shooting();
            }
        }
        else if (pool.bulletNumber >= 9)
        {
            pool.bulletNumber = -1;
        }

    }

    public void Shooting()
    {
        pool.bulletNumber++;
        pool.bullets[pool.bulletNumber].transform.position = disp.position;
        pool.bullets[pool.bulletNumber].transform.rotation = transform.rotation;

        pool.bullets[pool.bulletNumber].transform.Rotate(new Vector3(0, 0, -60), -60, Space.Self);
        pool.bullets[pool.bulletNumber].SetActive(true);
    }
}
