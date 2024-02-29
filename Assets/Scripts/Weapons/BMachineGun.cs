using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BMachineGun : Bullet
{
    //revisa posicion de la bala y cuando daña a enemigos
    protected RaycastHit2D inScreen;
    protected RaycastHit2D rayHit;

    GameObject target;
    BaseHitPont targetHit;
    private void Start()
    {
        
    }

    public override void Update()
    {
        // Chequea si esta dentro de la pantalla
        inScreen = Physics2D.Raycast(transform.position, transform.right, 1f, screen);
        // Chequea si golpea a un enemigo
        rayHit = Physics2D.Raycast(transform.position, transform.right, 1f, enemy);
        base.Update();

        // Si no esta en pantalla se desactiva y vuelve al origen
        if (!inScreen)
        {
            Debug.Log("out");
            gameObject.SetActive(false);
            transform.position = Vector3.zero;
        }

        /* Si golpea al collider del enemigo, llama al hitpoint y le pasa su damage
           luego se desactiva y vuelve al origen */
        if (rayHit)
        {
            Debug.Log("hit");
            target = rayHit.collider.gameObject;
            targetHit = target.GetComponent<BaseHitPont>();
            //MakeDamage(damage);
            targetHit.TakeDamage(damage);
            gameObject.SetActive(false);
            transform.position = Vector3.zero;
        }
    }

    public void MakeDamage(int newDamage)
    {
        targetHit.TakeDamage(newDamage);
        damage = newDamage;
    }
}
