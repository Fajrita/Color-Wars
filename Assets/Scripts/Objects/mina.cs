using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class mina : MonoBehaviour
{
    [SerializeField] public int damage;
    [SerializeField] protected LayerMask enemy;
    [SerializeField] float activeTime;

    protected RaycastHit2D rayHit;
    protected Collider2D [] rayExplode;
    GameObject target;
    BaseHitPont targetHit;
    void Start()
    {
        
    }
    void Update()
    {
        rayHit = Physics2D.CircleCast(transform.position, 0.5f, transform.right, 0f, enemy);
        rayExplode = Physics2D.OverlapCircleAll(transform.position, 2f,enemy);
        activeTime -= Time.deltaTime;

        if (activeTime <= 0)
        {
            if (rayHit)
            {
                Debug.Log(rayExplode.Length);
                foreach(Collider2D c in rayExplode)
                {

                    target =c.gameObject;
                    targetHit = target.GetComponent<BaseHitPont>();
                    Explode(damage);
                }
                Destroy(gameObject);
            } 
        }
    }

    public void Explode(int newDamage)
    {
        targetHit.TakeDamage(newDamage);
        damage = newDamage;
    }
}
