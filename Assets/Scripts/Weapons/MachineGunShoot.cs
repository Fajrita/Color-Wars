using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunShoot : MonoBehaviour
{
    [SerializeField]
    Transform father;

    [SerializeField]
    private float shootingTime = 1;
    private float shootingTimeCounter;

    private int bulletPoolSize = 10;
    public GameObject bullet;

    [HideInInspector]
    private GameObject[] bullets;
    [HideInInspector]
    private int bulletNumber = -1;
    void Start()
    {

        bullets = new GameObject[bulletPoolSize];
        for (int i = 0; i < bulletPoolSize; i++)
        {
            Debug.Log("bullet");
            bullets[i] = Instantiate(bullet, new Vector3(-10, -10f, -10f), Quaternion.identity, father);
        }
    }

    void Update()
    {

        if (shootingTimeCounter > 0)
        {
            shootingTimeCounter -= Time.deltaTime;
        }
        if (bulletNumber < 9)
        {
            if (shootingTimeCounter <= 0)
            {
                shootingTimeCounter = shootingTime;
                Shooting();
            }
        }
        else if (bulletNumber >= 9)
        {
            bulletNumber = -1;
        }

    }

    public void Shooting()
    {
        bulletNumber++;
        bullets[bulletNumber].transform.parent = father;
        bullets[bulletNumber].transform.position = transform.position;
        bullets[bulletNumber].transform.rotation = transform.rotation;
        bullets[bulletNumber].transform.parent = null;

        bullets[bulletNumber].SetActive(true);
        bullets[bulletNumber].transform.Rotate(new Vector3(0, 0, 135), 135, Space.Self);
    }
}
