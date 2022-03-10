using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clikker : MonoBehaviour
{
    public int money;

    public int addMoney = 1;

    public Text moneyText;


    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = money.ToString();
    }
    public void cliked()
    {
        money += addMoney;



    }
}

