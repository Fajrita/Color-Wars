using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Barrier : MonoBehaviour
{
    public float life = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int attack)
    {
        life -= attack;
        if (life <= 0)
        {
            if (gameObject.tag == "Tower")
            {
                Time.timeScale = 0;
            }
            else Destroy(gameObject);

        }

    }
}
