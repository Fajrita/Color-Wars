using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserShoot : MonoBehaviour
{
    [SerializeField]
    float shootingTime = 5;
    float shootingTimeCounter;
    float showingTime = 2;
    float showingTimeCounter;

    [SerializeField]
    Transform father;
    [SerializeField]
    GameObject preLaser;
    private GameObject laser;

    Color shootColor;
    void Start()
    {
        laser = Instantiate(preLaser, new Vector3(0,0,0), Quaternion.identity, father);
    }

    void Update()
    {
        shootColor = gameObject.GetComponentInParent<Image>().color;
        laser.GetComponentInChildren<SpriteRenderer>().color = shootColor;
        laser.transform.position = father.position;
        laser.transform.eulerAngles = (father.rotation.eulerAngles + new Vector3(0,0,45));

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
            laser.SetActive(false);
        }
    }

    public void Shooting()
    {
        laser.SetActive(true);
    }
}
