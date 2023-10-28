using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{

    bool advance;

    public void Start()
    {
        StartCoroutine(WaitMovement());
    }
    public void Update()
    {
        if (advance) { Movement(); }


    }

    public override void Movement()
    {
        base.Movement();
    }

    IEnumerator WaitMovement()
    {
        while (gameObject.activeSelf)
        {
            advance = true;
            yield return new WaitForSeconds(stop);
            advance = false;
            yield return new WaitForSeconds(stop);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Green")
        {
            Debug.Log("collision");
            BMachineGun bullet = collision.gameObject.GetComponent<BMachineGun>();

            TakeDamage(bullet.damage);
        }
    }

    public void TakeDamage(float damage)
    {
        life-= damage;
        if (life <= 0)
        {
            Destroy(self, 1);
        }
    }
}
