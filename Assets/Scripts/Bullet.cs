using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[System.Serializable]
public  class Bullet : MonoBehaviour
{
    // Clase base de bulltes
    [SerializeField] public int damage;
    [SerializeField] protected bool piercing;
    [SerializeField] public Color bColor;
    [SerializeField] protected float speed;
    [SerializeField] protected LayerMask enemy;
    [SerializeField] protected LayerMask screen;


    public virtual void Update()
    {
        if(gameObject.GetComponent<SpriteRenderer>() == null)
        {
            bColor = gameObject.GetComponentInChildren<SpriteRenderer>().color;
        }
        else {
            bColor = gameObject.GetComponent<SpriteRenderer>().color;
        }
       
        Movement();
    }
    public virtual void Movement()
    {
        // Movimiento recto 
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
