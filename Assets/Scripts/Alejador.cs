using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Alejador : MonoBehaviour
{
    GameObject[] allEnemies;
    float duration = 1;
   

    [SerializeField]
    float speed;

    [SerializeField]
    Transform tower;
    void Start()
    {
        allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        
    }

    void Update()
    {
        duration -= Time.deltaTime;

        if (duration > 0)
        {
            foreach (GameObject enemy in allEnemies)
                enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, tower.position, -speed * Time.deltaTime);
        } else
        {
            Destroy(gameObject);
        }
    }

}
