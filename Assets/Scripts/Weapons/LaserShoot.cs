using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShoot : MonoBehaviour
{
    public Transform disp;

    [SerializeField]
    float shootingTime = 5;
    float shootingTimeCounter;
    float showingTime = 2;
    float showingTimeCounter;
    [SerializeField]
    GameObject preLaser;
    private GameObject laser;
    void Start()
    {
        laser = Instantiate(preLaser, new Vector3(-10, -10f, -10f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (shootingTimeCounter > 0)
        {
            shootingTimeCounter -= Time.deltaTime;
            showingTimeCounter -= Time.deltaTime;
        }
        if (shootingTimeCounter <= 0)
        {
            showingTimeCounter = showingTime;
            shootingTimeCounter = shootingTime;
            Shooting();
        }
        if (showingTimeCounter <= 0)
        {
            Debug.Log("noshot");
            laser.SetActive(false);
        }
    }

    public void Shooting()
    {
        Debug.Log("shoot");
        laser.transform.position = disp.position;
        laser.transform.rotation = disp.rotation;
        laser.transform.Rotate(new Vector3(0, 0, 135), 135, Space.Self);
        laser.SetActive(true);
    }
}
