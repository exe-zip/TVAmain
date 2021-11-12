using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void ToStart()
    {
        SceneManager.LoadScene("Start");
    }
    public void ToTimerSelect()
    {
        SceneManager.LoadScene("TimerSelect");
    }
    public void ToMember()
    {
        SceneManager.LoadScene("Member");
    }
    public void ToPosition()
    {
        SceneManager.LoadScene("Position");
    }


}
