using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Device;
using static UnityEngine.GraphicsBuffer;

[System.Serializable]
public class Enemy : MonoBehaviour
{
    // Clase base para todos los enemigos

    [SerializeField] protected float attack;
    [SerializeField] protected float speed;
    [SerializeField] protected float stop;
    [SerializeField] protected Transform target;

    protected RaycastHit2D inBarrier;
    [SerializeField] protected LayerMask barrier;

    public virtual void Start()
    {

    }

    public virtual void Update()
    {
        // Chequea si esta en la barrera
        inBarrier = Physics2D.CircleCast(transform.position, 0.7f, transform.right, 0.1f, barrier);
        // Destruye al enemigo despues de perder todos sus hit points
        if (transform.childCount <= 0)
        {
            Destroy(gameObject);
        }
    }

    public virtual void Movement() 
    {
        /* Movimiento continuo de acercarse a la torre
         si esta en la barrera se detiene */
        if (!inBarrier)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

   

}
