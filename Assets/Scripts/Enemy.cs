using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Device;
using static UnityEngine.GraphicsBuffer;

[System.Serializable]
public class Enemy : MonoBehaviour
{
    // Clase base para todos los enemigos

    [SerializeField] protected int attack;
    [SerializeField] protected float speed;
    [SerializeField] protected float stop;
    [SerializeField] public Transform target;

    protected RaycastHit2D inBarrier;
    protected GameObject barrier;
    protected Barrier scriptBarrier;
    protected bool isAttacking;
    [SerializeField] protected LayerMask layerBarrier;

    public GameObject manager;

    public virtual void Start()
    {
    }

    public virtual void Update()
    {
        // Chequea si esta en la barrera
        inBarrier = Physics2D.CircleCast(transform.position, 0.7f, transform.right, 0.1f, layerBarrier);
        // Destruye al enemigo despues de perder todos sus hit points
        if (!transform.Find("HitPoint")) 
        {
            manager.GetComponent<EnergySpawn>().Spawn(transform);
            Destroy(gameObject);
        }

        if (inBarrier && !isAttacking)
        {

            barrier = inBarrier.collider.gameObject;
            scriptBarrier = barrier.GetComponent<Barrier>();
            StartCoroutine(AttackBarrier());

        }
    }

    public virtual void Movement()
    {
        /* Movimiento continuo de acercarse a la torre
         si esta en la barrera se detiene */
        if (!inBarrier) transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    IEnumerator AttackBarrier()
    {
        isAttacking = true;
        scriptBarrier.TakeDamage(attack);
        yield return new WaitForSeconds(1);
        isAttacking= false;

    }

   

}
