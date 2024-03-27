using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class Mine : MonoBehaviour
{

    BaseHitPont targetHit;
    GameObject target;
    [SerializeField] public int damage;

    public CircleCollider2D myCollider;

    void Start()
    {
        Invoke("Explosion", 2f);
    }

    void Explosion()
    {
        myCollider.enabled = true;
        Destroy(gameObject, 1);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            target = collision.GetComponent<GameObject>();
            targetHit = target.GetComponent<BaseHitPont>();
            Explode(damage);

        }
    }

    public void Explode(int newDamage)
    {
        targetHit.TakeDamage(newDamage);
        damage = newDamage;
        Destroy(gameObject);
    }

}
