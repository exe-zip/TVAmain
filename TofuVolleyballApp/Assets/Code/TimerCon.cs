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
        public float settime { get; set; }

        public void Tohms(float sonly)
        {
            this.h = (int)(sonly / 3600f);
            this.m = (int)((sonly % 3600f) / 60f);
            this.s = (sonly % 3600f) % 60f;
        }
        public void Set(float set)
        {
            Tohms(set);
            settime = set;
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
        public void Reset()
        {
            Tohms(settime);
        }
    }

    public TextMeshProUGUI timetext;
    public TextMeshProUGUI menutext;
    Hms nowtime = new Hms();
    public bool mode = false;
    string[] menuname = new string[64];
    int nownum = 0;
    void Start()
    {
        nowtime.Set(3663f);
        menuname[0] = "pass";
        menuname[1] = "serve";
    }

    void Update()
    {
        if (mode)
        {
            nowtime.Count();
        }
        timetext.text = nowtime.Tostr();
        menutext.text = menuname[nownum];
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

    public void Timereset()
    {
        nowtime.Reset();
    }
}
