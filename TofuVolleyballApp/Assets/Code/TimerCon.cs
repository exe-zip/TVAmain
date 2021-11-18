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
        public bool mode { get; set; }
        public List<float> menutime { get; set; } = new List<float>();

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
                    if (this.h == 0)
                    {
                        Next();
                    }
                    else
                    {
                        this.m = 60;
                        this.h--;
                    }
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
            if (num!=this.menutime.Count-1)
            {
                num++;
                Set();
            }
            else
            {
                End();
            }
        }
        public void Back()
        {
            if (num >= 1)
            {
                num--;
                Set();
            }
        }
        public void End()
        {
            num = 0;
            Set();
            mode = false;
        }
    }

    public TextMeshProUGUI timetext;
    public TextMeshProUGUI menutext;
    public Hms nowtime = new Hms();
    string[] menuname = new string[64];
    List<float> inputmenutime = new List<float>();

    void Start()
    {
        nowtime.mode = false;
        nowtime.num = 0;
        inputmenutime.Add(5f);
        inputmenutime.Add(3603f);
        inputmenutime.Add(4f);
        nowtime.menutime= inputmenutime;
        nowtime.Set();
        menuname[0] = "pass";
        menuname[1] = "serve";
    }

    void Update()
    {
        if (nowtime.mode)
        {
            nowtime.Count();
        }
        timetext.text = nowtime.Tostr();
        menutext.text = menuname[nowtime.num];
    }

    public void Modechange()
    {
        nowtime.mode = !nowtime.mode;
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
