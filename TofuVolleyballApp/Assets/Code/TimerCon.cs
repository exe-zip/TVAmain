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
            return string.Format("{0}:{1:d2}:{2:d2}",this.h,this.m,this.s);
        }
    }

    public TextMeshProUGUI timetext;
    int settime;
    float nowtimef = 0;
    Hms nowtime = new Hms();
    public bool mode = false;
    void Start()
    {
        settime = 78;
        nowtime.Sethms(settime);
    }

    void Update()
    {
        if (mode)
        {

        }
        timetext.text = nowtime.Tostr();
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
        
    }
}
