using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerCon : MonoBehaviour
{
    public TextMeshProUGUI timetext;
    bool mode = false;
    float deltatime = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (mode)
        {
            deltatime += Time.deltaTime;
        }
        timetext.text = deltatime.ToString();
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
