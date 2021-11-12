using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerCon : MonoBehaviour
{
    public TextMeshProUGUI timetext;
    float deltatime = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        deltatime += Time.deltaTime;
        timetext.text = deltatime.ToString();
    }
}
