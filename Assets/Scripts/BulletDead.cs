using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDead : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Background"))
        {
            gameObject.SetActive(false);
            transform.position = Vector3.zero;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Background"))
        {
            gameObject.SetActive(false);
            transform.position = Vector3.zero;
        }
    }
}
