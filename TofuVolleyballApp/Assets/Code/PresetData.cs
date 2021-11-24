using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PresetData : MonoBehaviour
{
    public class PreData
    {
        public List<float> _menutime { get; set; } = new List<float>();
        public List<string> _menuname { get; set; } = new List<string>();
        public string prename { get; set; } = "New Preset";
        public void Addmenu(float time,string name)
        {
            this._menutime.Add(time);
            this._menuname.Add(name);
        }
    }

    public GameObject botton;
    public GameObject contents;
    public Text aa;
    public List<PreData> preset = new List<PreData>();
    public PreData newdata = new PreData();

    public string addprename;
    
    void Start()
    {
        addprename = "Test";
        aa.text = "hoge";
    }

    void Update()
    {
        
    }

    public void Clone()
    {
        GameObject clone= Instantiate(botton);
        clone.transform.parent = contents.transform;
    }

    public float Tosonly(int h,int m,int s)
    {
        return (float)(3600 * h + 60 * m + s);
    }

    public void Adddata(float time,string name)
    {
        newdata.Addmenu(time, name);
        preset.Add(newdata);
    }
}
