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
    protected LayerMask Enemy = 6;


    public static int Damage(int damage)
    {
        return damage;
    }
    //public virtual void Movement()
    //{
    //    transform.Translate(speed * Time.deltaTime, 0, 0);
    //}
}
