using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDead : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        transform.position = Vector3.zero;
    }
}
