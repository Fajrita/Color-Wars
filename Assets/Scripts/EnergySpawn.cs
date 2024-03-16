using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnergySpawn : MonoBehaviour
{
    public GameObject energy;
    private GameObject myEnergy;
    public int probability;
    private int total;

    public int nCoin;
    public TMP_Text mText;

    void Update()
    {
        mText.SetText(nCoin.ToString());
    }

    public void Spawn (Transform enemy) 
    {
        total = Random.Range(0, 100);
        if (probability >= total)
        {
            myEnergy = Instantiate(energy, enemy);
            myEnergy.transform.SetParent(null);
            myEnergy.SetActive(true);
        }
        
    }
}
