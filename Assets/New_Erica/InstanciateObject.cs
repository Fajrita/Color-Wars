using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateObject : MonoBehaviour
{
    private Vector3 mousePos;
    private Vector3 objectPos;
    public GameObject mine;


    void InstanciateMyObj()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 2.0f;
        objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        Instantiate(mine, objectPos, Quaternion.identity);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
