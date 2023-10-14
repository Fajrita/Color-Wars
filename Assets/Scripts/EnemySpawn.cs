using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
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
    void Start()
    {
        x1 = Random.Range(-20,-8);
        x2 = Random.Range(-8,7);
        x3 = Random.Range(7,20);
        x = new[] {x1,x1,x2,x3,x3}; 
        top = new Vector2(x[Random.Range(0,x.Length)], 11);
        bottom = new Vector2(x[Random.Range(0, x.Length)], -13);
        left = new Vector2(-21, Random.Range(11, -13));
        right = new Vector2(20, Random.Range(11, -13));
        sides = new[] { top, bottom, left, right};

        enemies = new GameObject[enemyPoolSize];
        for (int i = 0; i < enemyPoolSize; i++)
        {
            enemies[i] = Instantiate(enemy, new Vector3(-10, -10f, -10f), Quaternion.identity);
        }
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn() 
    {
        while (enemyNumber < 9)
        { 
            spawnPoint = Random.Range(0, sides.Length);
            enemyNumber++;
            enemies[enemyNumber].transform.position = sides[spawnPoint];
            enemies[enemyNumber].SetActive(true);
            yield return new WaitForSeconds(Random.Range(2,4));
        }
        
    }
}
