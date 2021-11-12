using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerCon : MonoBehaviour
{
    public class Hms
    {
        public int h { get; set; }
        public int m { get; set; }
        public int s { get; set; }
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

    Hms Tohms(int sonly)
    {
        var HMS = new Hms() { h = sonly / 3600 , m = (sonly % 3600) / 60 , s = (sonly % 3600) % 60 };
        return HMS;
    }
}
