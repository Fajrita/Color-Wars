using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    [SerializeField]
    float speed;

    Vector2 position;
    bool advance;

    private void Start()
    {
        StartCoroutine(Movement());
    }

    void Update()
    {
        if (advance) { InMove(); }
        else if (!advance) { InStop(); }

        //direct movement
        //transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    IEnumerator Movement() 
    {
        while (gameObject.activeSelf)
        {
            advance = true;
            yield return new WaitForSeconds(0.5f);
            advance = false;
            yield return new WaitForSeconds(0.5f);
        }
      
    }
    void InMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    void InStop()
    {
        position = transform.position;
        transform.position = position;
    }
}
