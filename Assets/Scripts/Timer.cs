using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text textTimer;
    public string result;
    float gameTimer = 0f;

    private void Update()
    {
        gameTimer += Time.deltaTime;

        int hours = (int)(gameTimer/3600) % 24;
        int minutes = (int)(gameTimer/60) % 60;
        int seconds = (int)(gameTimer % 60);

        result = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);
        textTimer.text = result;
    }


}
