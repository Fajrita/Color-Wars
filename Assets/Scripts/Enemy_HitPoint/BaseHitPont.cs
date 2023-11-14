using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHitPont : HitPoint
{
    //public override void OnTriggerEnter2D(Collider2D collision)
    //{
    //    base.OnTriggerEnter2D(collision);
    //}

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }
}
