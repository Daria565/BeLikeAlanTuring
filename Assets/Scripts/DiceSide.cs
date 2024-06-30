using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DiceSide : MonoBehaviour
{

    bool onBoard;
    public int sideValue;
 
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Table") {
             onBoard = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Table") {
            onBoard = false;
        }
    }

    public bool OnBoard() 
    { 
        return onBoard;
    }
}
