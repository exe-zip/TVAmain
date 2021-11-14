using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TimerCon : MonoBehaviour
{
    public class Hms
    {
        public int h { get; set; }
        public int m { get; set; }
        public float s { get; set; }
        public void Sethms(float sonly)
        {
            this.h = (int)(sonly / 3600f);
            this.m = (int)((sonly % 3600f) / 60f);
            this.s = (sonly % 3600f) % 60f;
        }
        public string Tostr()
        {
            return string.Format("{0}:{1:D2}:{2:D2}",this.h,this.m,(int)this.s);
        }
        public void Count()
        {
            if (this.s-Time.deltaTime <= 0)
            {
                this.s = this.s + 60f - Time.deltaTime;
                this.m--;
            }
            else
            {
                this.s -= Time.deltaTime;
            }
        }
    }

    public TextMeshProUGUI timetext;
    float settime;
    float nowtimef = 0;
    Hms nowtime = new Hms();
    public bool mode = false;
    void Start()
    {
        settime = 3665f;
        nowtime.Sethms(settime);
    }

    void Update()
    {
        if (mode)
        {
            nowtime.Count();
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
}
