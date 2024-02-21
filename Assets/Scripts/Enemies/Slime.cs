using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    bool advance;

    public override void Start()
    {
        base.Start();
        StartCoroutine(WaitMovement());
    }
    public override void Update()
    {
        base .Update();
        if (advance) { Movement(); }
    }

    public override void Movement()
    {
        base.Movement();
    }

    IEnumerator WaitMovement()
    {
        // Movimiento de slimes, avanza, espera, avanza
        while (gameObject.activeSelf)
        {
            advance = true;
            yield return new WaitForSeconds(stop);
            advance = false;
            yield return new WaitForSeconds(stop);
        }
    }
}
