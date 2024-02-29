using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineGunShoot : MonoBehaviour
{
    // instancia la bala, le da su velocidad de disparo y su ubicacion de inicio
    [SerializeField]
    Transform father;

    [SerializeField]
    private float shootingTime = 1;
    private float shootingTimeCounter;

    private int bulletPoolSize = 5;
    public GameObject bullet;

    [HideInInspector]
    private GameObject[] bullets;
    [HideInInspector]
    private int bulletNumber = -1;

    Color shootColor;
    void Start()
    {
        // Se instancian las bullets segun el poolsize
        bullets = new GameObject[bulletPoolSize];
        for (int i = 0; i < bulletPoolSize; i++)
        {
            bullets[i] = Instantiate(bullet, new Vector3(-10, -10f, -10f), Quaternion.identity, father);
        }
    }

    void Update()
    {
        shootColor = gameObject.GetComponentInParent<Image>().color;
        //tiempo entre disparos y conteo de balas maximas
        if (shootingTimeCounter > 0)
        {
            shootingTimeCounter -= Time.deltaTime;
        }
        if (bulletNumber < 4)
        {
            if (shootingTimeCounter <= 0)
            {
                shootingTimeCounter = shootingTime;
                Shooting();
            }
        }
        else if (bulletNumber >= 4)
        {
            bulletNumber = -1;
        }

    }

    public void Shooting()
    {
        /* father es de donde sale la bala disparada, copia su rotacion y posicion,
         luego se desemparenta y se activa con la direccion correcta de disparo */
        bulletNumber++;
        bullets[bulletNumber].transform.parent = father;
        bullets[bulletNumber].GetComponent<SpriteRenderer>().color = shootColor;
        bullets[bulletNumber].transform.position = transform.position;
        bullets[bulletNumber].transform.rotation = transform.rotation;
        bullets[bulletNumber].transform.parent = null;

        bullets[bulletNumber].SetActive(true);
        bullets[bulletNumber].transform.Rotate(new Vector3(0, 0, 135), 135, Space.Self);
    }
}
