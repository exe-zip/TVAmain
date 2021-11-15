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
        public int num { get; set; }
        public float[] menutime { get; set; } = new float[64];

        public void Tohms(float sonly)
        {
            this.h = (int)(sonly / 3600f);
            this.m = (int)((sonly % 3600f) / 60f);
            this.s = (sonly % 3600f) % 60f;
        }
        public void Set()
        {
            Tohms(menutime[num]);
        }
        public string Tostr()
        {
            return string.Format("{0}:{1:D2}:{2:D2}",this.h,this.m,(int)this.s);
        }
        public void Count()
        {
            if (this.s-Time.deltaTime <= 0)
            {
                if (this.m == 0)
                {
                    Next();
                }
                else
                {
                    this.s = this.s + 60f - Time.deltaTime;
                    this.m--;
                }
            }
            else
            {
                this.s -= Time.deltaTime;
            }
        }
        public void Next()
        {
            num++;
            Set();
        }
        public void Back()
        {
            num--;
            Set();
        }
    }

    public TextMeshProUGUI timetext;
    public TextMeshProUGUI menutext;
    Hms nowtime = new Hms();
    public bool mode = false;
    string[] menuname = new string[64];
    float[] inputmenutime = new float[64];

    void Start()
    {
        nowtime.num = 0;
        inputmenutime[0] = 5f;
        inputmenutime[1] = 3663f;
        nowtime.menutime= inputmenutime;
        nowtime.Set();
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
        menutext.text = menuname[nowtime.num];
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
        nowtime.Set();
    }

    public void Backmenu()
    {
        nowtime.Back();
    }

    public void Nextmenu()
    {
        nowtime.Next();
    }
}
