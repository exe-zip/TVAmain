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


    }

    void Update()
    {
        if (manager_timer.GetComponent<TimerCon>().nowtime.mode)
        {
            botton_startstop.text = "Stop";
        }
        else
        {
            botton_startstop.text = "Start";
        }
    }
}
