using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Alejador : MonoBehaviour
{
    GameObject[] allEnemies;
    protected Collider2D[] enemies;
    GameObject target;
    [SerializeField] protected LayerMask enemy;
    public float duration = 1;
   

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
        gameObject.transform.position = tower.position;
        enemies = Physics2D.OverlapCircleAll(transform.position, 100f, enemy);
        duration -= Time.deltaTime;

        if (duration > 0)
        {
            Debug.Log(enemies.Length);
            foreach (Collider2D c in enemies)
            {
                
                target = c.gameObject.transform.parent.gameObject;
                target.transform.position = Vector3.MoveTowards(target.transform.position, tower.position, -speed * Time.deltaTime);
            }
            
        } else
        {

            Destroy(gameObject);
        }
    }

}
