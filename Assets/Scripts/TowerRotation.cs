using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class TowerRotation : MonoBehaviour
{
    [SerializeField]
    float rotSpeed = 5f;
    float input;
    PlayerInput inputPlayer;
    bool isRotating;
    void Start()
    {
        inputPlayer = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        input = inputPlayer.actions["Rotate"].ReadValue<Vector2>().x;
        
        if ((Mathf.Abs(input) > 0.01))
        {
            Rotate();
        }
    }

    void Rotate()
    {
        transform.Rotate(new Vector3(0,0, input * rotSpeed * Time.deltaTime), Space.Self);
    }
}
