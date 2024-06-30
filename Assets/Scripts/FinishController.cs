using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishController : MonoBehaviour
{
    public string res;
    public Text textTimer;
  
    void Start()
    {
        res = GlobalV.timeResult;
        textTimer.text = res;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
