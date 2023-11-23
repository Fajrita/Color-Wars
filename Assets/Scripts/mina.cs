using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class mina : MonoBehaviour
{
    [SerializeField] public int damage;
    [SerializeField] protected LayerMask enemy;
    float activeTime = 5;

    protected RaycastHit2D rayHit;
    GameObject target;
    BaseHitPont targetHit;
    void Start()
    {
        
    }
    void Update()
    {
        // revisar direccion del hit right, talvez hacer mas de uno
        rayHit = Physics2D.Raycast(transform.position, transform.right, 1f, enemy);
        activeTime -= Time.deltaTime;

        if (activeTime <= 0)
        {
            if (rayHit)
            {
                target = rayHit.collider.gameObject;
                targetHit = target.GetComponent<BaseHitPont>();
                Explode(damage);
                gameObject.SetActive(false);
                transform.position = Vector3.zero;
            }
            
        }
    }

    public void Explode(int newDamage)
    {
        targetHit.TakeDamage(newDamage);
        damage = newDamage;
        Destroy(gameObject);
    }
}
