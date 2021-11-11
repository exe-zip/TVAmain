using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToStart()
    {
        SceneManager.LoadScene("Start");
    }
    public void ToTimer()
    {
        SceneManager.LoadScene("Timer");
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
