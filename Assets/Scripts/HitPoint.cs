using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoint : MonoBehaviour
{
    float takingDamageTime = 1;
    float takingDamageCounter;

    [SerializeField] protected int life;
    [SerializeField] protected string[] color;
    //public virtual void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == color[0])
    //    {
    //        Debug.Log("collision");
    //        BMachineGun bullet = collision.gameObject.GetComponent<BMachineGun>();
    //        TakeDamage(bullet.damage);
    //    }
    //}

    public  virtual void TakeDamage(int damage)
    {
        life -= damage;
        if (life <= 0)
        {
            Debug.Log("dead");
            Destroy(gameObject);
        }
    }

    public virtual void TimeTakeDamage(int damage)
    {
        if (takingDamageCounter > 0)
        {
            takingDamageCounter -= Time.deltaTime;
        }
        else
        {
            life -= damage;
            takingDamageCounter = takingDamageTime;
            if (life <= 0)
            {
                Debug.Log("dead");
                Destroy(gameObject);
            }
        }
    }
}
