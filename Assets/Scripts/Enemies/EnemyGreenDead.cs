using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGreenDead : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Green")
        {
            gameObject.SetActive(false);
        }
    }
}
