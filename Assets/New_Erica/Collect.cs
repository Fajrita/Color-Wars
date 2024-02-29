using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collect : MonoBehaviour
{
    public int nCoins;
    public int value;
    public TMP_Text mText;

    private void Update()
    {
        nCoins = int.Parse(mText.text);
    }

    public void Collected()
    {
        nCoins += value;
        mText.text = "" + nCoins;
        gameObject.SetActive(false);
    }

    
}
