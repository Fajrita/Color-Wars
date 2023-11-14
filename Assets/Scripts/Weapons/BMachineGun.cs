using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BMachineGun : Bullet
{
    protected RaycastHit2D rayHit;
    GameObject target;
    BaseHitPont targetHit;
    private void Start()
    {
        
    }
    
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Background"))
    //    {
    //        gameObject.SetActive(false);
    //        transform.position = Vector3.zero;
    //    }
    //}
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        gameObject.SetActive(false);
    //        transform.position = Vector3.zero;
    //    }
    //}

    public override void Update()
    {

        rayHit = Physics2D.Raycast(transform.position, transform.right, 1f, enemy);
        base.Update();

        if(rayHit)
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
