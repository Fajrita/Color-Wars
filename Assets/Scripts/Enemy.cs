using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

[System.Serializable]
public class Enemy : MonoBehaviour
{
    [SerializeField] protected float attack;
    [SerializeField] protected float speed;
    [SerializeField] protected float stop;
    [SerializeField] protected Transform target;
    [SerializeField] protected GameObject self;

    public virtual void Start()
    {

    }

    public virtual void Update()
    {
        if (transform.childCount <= 0)
        {
            Destroy(self);
        }
    }
    public virtual void Movement() 
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

   

}
