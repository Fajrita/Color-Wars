using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoint : MonoBehaviour
{
    // Clase Hitpoint, todos heredan de aqui
    float takingDamageTime = 1;
    float takingDamageCounter;

    [SerializeField] protected int life;
    [SerializeField] protected string[] color;

    public  virtual void TakeDamage(int damage)
    {
        /* Recibe el damage de las armas, y lo resta a la vida del hitpoint
           Si la vida es 0 se destruye el hitponit */
        life -= damage;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

    public virtual void TimeTakeDamage(int damage)
    {
        /* Para armas que generan daño constantemente esto hace que haya,
           un tiempo de espera entre el daño que va recibiendo*/
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
                Destroy(gameObject);
            }
        }
    }
}
