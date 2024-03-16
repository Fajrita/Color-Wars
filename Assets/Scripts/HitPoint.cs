using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class HitPoint : MonoBehaviour
{
    // Clase Hitpoint, todos heredan de aqui
    float takingDamageTime = 1;
    float takingDamageCounter;

    [SerializeField] protected int life;
    [SerializeField] public Color color;

    public  virtual void TakeDamage(int damage)
    {
        /* Recibe el damage de las armas, y lo resta a la vida del hitpoint
           Si la vida es 0 se destruye el hitponit */
        life -= damage;
        StartCoroutine(ColorDamage());
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
            StartCoroutine(ColorDamage());
            takingDamageCounter = takingDamageTime;
            if (life <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    IEnumerator ColorDamage() 
    {

        for (int i = 0; i < transform.parent.childCount; i++)
        {
            var brother = transform.parent.GetChild(i);
            if (brother.GetComponent<SpriteRenderer>())
            {
                brother.GetComponent<SpriteRenderer>().color = Color.red;
            }
            
        }
        yield return new WaitForSeconds(0.2f);

        for (int i = 0; i < transform.parent.childCount; i++)
        {
            var brother = transform.parent.GetChild(i);
            if (brother.GetComponent<SpriteRenderer>())
            {
                brother.GetComponent<SpriteRenderer>().color = Color.white;
            }
        }
    }   
}
