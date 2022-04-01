using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autockicker : MonoBehaviour
{
    public float addSperm;
    public float price;
    public int amountOfitem;
    float currenTime;
    float cooldownTime = 1;

    clikker clikkerScript;

    // Start is called before the first frame update
    void Start()
    {
        currenTime = cooldownTime;
        clikkerScript = FindObjectOfType<clikker>();

    }

    // Update is called once per frame
    void Update()
    {
        currenTime -= Time.deltaTime;

        if (currenTime <= 0)
        {
            clikkerScript.autoClick(addSperm * amountOfitem);
            currenTime = cooldownTime;

        }
        
    }
    public void buyItem()
    {
        if (clikkerScript.sperm >= price)
        {
            clikkerScript.sperm -= price;
            amountOfitem++;
            price *= 1.30f;
            price = Mathf.Round(price * 100f) / 100f;

        }
        

    }
}
