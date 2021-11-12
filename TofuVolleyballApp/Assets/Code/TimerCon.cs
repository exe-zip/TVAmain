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
        public void Sethms(int sonly)
        {
            this.h = sonly / 3600;
            this.m = (sonly % 3600) / 60;
            this.s = (sonly % 3600) % 60;
        }
        public string Tostr()
        {
            return $"{this.h}:{this.m}:{this.s}";
        }
    }

    public TextMeshProUGUI timetext;
    int settime;
    float nowtime = 0;
    public bool mode = false;

    void Start()
    {
        settime = 3841;
        nowtime=
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
}
