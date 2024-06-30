using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowTask3 : MonoBehaviour
{
    public string answer;
    public GameObject inputField;

    public Health health;

    public void SaveInput()
    {

        if (inputField.GetComponent<Text>() != null)
        {
            answer = inputField.GetComponent<Text>().text;
            CheckResult();

        }
      
    }

   
    public void CheckResult()
    {
        if (string.Compare(answer,"HYMNAL",true)==0)
        {
            Debug.Log("It's correct!");
            health.Increment();
        }
        else
        {
            Debug.Log("Oh, no!");
            health.Decrement();
        }
    }
}
