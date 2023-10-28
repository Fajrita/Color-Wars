using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BMachineGun : Bullet
{
    private void OnCollisionEnter2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag == color[0] && enemy.gameObject.layer == Enemy )
        {

        }
    }

  
    public static new int Damage(int damage)
    {
        return damage;
    }
}
