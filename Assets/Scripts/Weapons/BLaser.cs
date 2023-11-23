using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLaser : Bullet
{
    protected RaycastHit2D rayHit;
    GameObject target;
    BaseHitPont targetHit;
    void Start()
    {
        
    }
    public override void Update()
    {
        rayHit = Physics2D.Raycast(transform.position, transform.up, 8f, enemy);
        base.Update();

        if (rayHit)
        {
            Debug.Log("laserhit");
            target = rayHit.collider.gameObject;
            targetHit = target.GetComponent<BaseHitPont>();
            MakeDamage(damage);
        }
    }

    public void MakeDamage(int newDamage)
    {
        targetHit.TimeTakeDamage(newDamage);
        damage = newDamage;
    }
}
