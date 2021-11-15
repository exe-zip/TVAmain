using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCon : MonoBehaviour
{
    public Text botton_startstop;
    public GameObject manager_timer;
    void Start()
    {
        Texturechange_startstop();
    }

    void Update()
    {

    }

    public void Texturechange_startstop()
    {
        if (manager_timer.GetComponent<TimerCon>().getmode)
        {
            botton_startstop.text = "Stop";
        }
        else
        {
            botton_startstop.text = "Start";
        }
    }
}
