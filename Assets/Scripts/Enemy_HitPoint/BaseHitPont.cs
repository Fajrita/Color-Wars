using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHitPont : HitPoint
{
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }
    public override void TimeTakeDamage(int damage)
    {
        base.TimeTakeDamage(damage);
    }
}
