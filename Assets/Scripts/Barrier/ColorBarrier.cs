using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBarrier : MonoBehaviour
{
    float fullLife;
    float percentLife;
    float value1;
    // Start is called before the first frame update
    void Start()
    {
        fullLife = gameObject.GetComponentInParent<Barrier>().life;
    }

    // Update is called once per frame
    void Update()
    {
        var parentLife = gameObject.GetComponentInParent<Barrier>().life;
        percentLife = (parentLife * 100) / fullLife;

        if(percentLife <= 100 && percentLife > 50 )
        {
            value1 = (percentLife - 50) / 50;
            gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(Color.yellow, Color.white, value1);

        }
        else if (percentLife <= 50)
        {
            value1 = percentLife / 50;
            gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(new Color(0.6981132f,0,0,1), Color.yellow,value1);
            
        }
    }
}
