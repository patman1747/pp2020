using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clikker : MonoBehaviour
{
    public float sperm;

    public float addSperm;

    public Text spermText;

    public AudioSource Audio_;

    public AudioClip ClickSound;

    public float muti = 1;

    // Start is called before the first frame update
    void Start()
    {
        Audio_ = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        spermText.text = sperm.ToString("F2");

    }

    public void cliked()   
    {
        sperm += (addSperm * muti);

        Audio_.PlayOneShot(ClickSound);

    }
    public void autoClick(float addSperm)
    {
        sperm += addSperm;


    }
    public void multiplyer()
    {
        addSperm *= muti;


    }

    
}







