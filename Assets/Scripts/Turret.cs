using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] protected float attack;
    [SerializeField] protected float speed;
    [SerializeField] protected float stop;
    [SerializeField] protected Transform target;
    [SerializeField] protected GameObject self;
}
