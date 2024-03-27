using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Sistema de spawneo e instanciamiento de enemigos
    public GameObject [] enemy;
    int numEnemigo;
    public int enemyPoolSize = 10;

    [HideInInspector]
    public GameObject[] enemies;
    [HideInInspector]
    public int enemyNumber = -1;

    int spawnPoint;
    float x1;
    float x2;
    float x3;
    float[] x;
    Vector2 top;
    Vector2 bottom;
    Vector2 left;
    Vector2 right;
    Vector2[] sides;

    // Gestion velocidad de Spawn Enemigos
    public float minVelocity;
    public float maxVelocity;

    void Start()
    {
        //instancia la cantidad de enemigos del pool fuera de escena
        enemies = new GameObject[enemyPoolSize];
        
        for (int i = 0; i < enemyPoolSize; i++)
        {
            numEnemigo = Random.Range(0, enemy.Length);
            enemies[i] = Instantiate(enemy[numEnemigo], new Vector3(-10, -10f, -10f), Quaternion.identity);
            enemies[i].SetActive(false);
        }
        StartCoroutine(Spawn());
    }

    /* Spawnea un enemigo en un punto random, aumenta el conteo,
     activa al gameobj y espera un tiempo random para el siguiente spawneo */
    IEnumerator Spawn() 
    {
        while (enemyNumber < enemyPoolSize-1)
        {
            // rangos para que aparescan mas enemigos por los bordes mas alejados
            x1 = Random.Range(-20f, -8f);
            x2 = Random.Range(-8f, 7f);
            x3 = Random.Range(7f, 20f);
            x = new[] { x1, x3, x2, x1, x3 };

            //lados de posible aparicion de enemigos
            top = new Vector2(x[Random.Range(0, x.Length)], 11f);
            bottom = new Vector2(x[Random.Range(0, x.Length)], -13f);
            left = new Vector2(-21, Random.Range(11f, -13f));
            right = new Vector2(20, Random.Range(11f, -13f));
            sides = new[] { top, bottom, left, right };

            spawnPoint = Random.Range(0, sides.Length);
            enemyNumber++;
            enemies[enemyNumber].transform.position = sides[spawnPoint];
            enemies[enemyNumber].SetActive(true);
            yield return new WaitForSeconds(Random.Range(minVelocity,maxVelocity));
        }
        
    }
}
