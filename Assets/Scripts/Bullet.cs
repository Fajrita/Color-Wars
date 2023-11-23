using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[System.Serializable]
public  class Bullet : MonoBehaviour
{
    [SerializeField] public int damage;
    [SerializeField] protected bool piercing;
    [SerializeField] protected string[] color;
    [SerializeField] protected float speed;
    [SerializeField] protected LayerMask enemy;
    [SerializeField] protected LayerMask screen;

    public virtual void Update()
    {
        Movement();
    }
    public virtual void Movement()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
