using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerCon : MonoBehaviour
{
    struct hms
    {
        int h;
        int m;
        int s;
    }

    public TextMeshProUGUI timetext;
    int settime;
    float nowtime = 0;
    public bool mode = false;

    void Start()
    {
        settime = 3841;
    }

    void Update()
    {
        if (mode)
        {

        }
        timetext.text = nowtime.ToString();
    }

    public void Modechange()
    {
        if (mode)
        {
            mode = false;
        }
        else
        {
            mode = true;
        }
    }

    void Countdown()
    {
        nowtime -= Time.deltaTime;
    }

    void Tohms(int s)
    {

    }
}
