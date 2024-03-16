using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collect : MonoBehaviour
{
    public int value;
    private GameObject manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
    }
    public void Collected()
    {
        manager.GetComponent<EnergySpawn>().nCoin += value;
        Destroy(gameObject);
    }

    
}
