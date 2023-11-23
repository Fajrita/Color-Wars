using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BMachineGun : Bullet
{
    protected RaycastHit2D inScreen;
    protected RaycastHit2D rayHit;

    GameObject target;
    BaseHitPont targetHit;
    private void Start()
    {
        
    }

    public override void Update()
    {
        inScreen = Physics2D.Raycast(transform.position, transform.right, 1f, screen);
        rayHit = Physics2D.Raycast(transform.position, transform.right, 1f, enemy);
        base.Update();

        if (!inScreen)
        {
            gameObject.SetActive(false);
            transform.position = Vector3.zero;
        }

        if (rayHit)
        {
            target = rayHit.collider.gameObject;
            targetHit = target.GetComponent<BaseHitPont>();
            MakeDamage(damage);
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
