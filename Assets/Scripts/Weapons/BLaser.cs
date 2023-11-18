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

    // Update is called once per frame
    public override void Update()
    {
        rayHit = Physics2D.Raycast(transform.position, transform.right, 1f, enemy);
        base.Update();

        if (rayHit)
        {
            Debug.Log(rayHit.transform.name);
            target = rayHit.collider.gameObject;
            targetHit = target.GetComponent<BaseHitPont>();
            MakeDamage(damage);
            gameObject.SetActive(false);
            transform.position = Vector3.zero;
        }
    }
    public void MakeDamage(int newDamage)
    {
        Debug.Log("damage");
        targetHit.TakeDamage(newDamage);
        damage = newDamage;
    }
}
