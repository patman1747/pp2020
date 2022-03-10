using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clikker : MonoBehaviour
{
    public int sperm;
   

    public int addSperm = 1;

    public Text spermText;


    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        spermText.text = sperm.ToString();
    }
    public void cliked()
    {
        sperm += addSperm;



    }
}

