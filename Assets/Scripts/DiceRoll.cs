using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using Random = UnityEngine.Random;

public class DiceRoll : MonoBehaviour
{
    Rigidbody body;
    private float forceX, forceY, forceZ;
    public float maxRandomForceValue, startForce;
    public int DiceSideNum;
  
    private bool rolled;

    public DiceSide[] diceSides;
    public PlayerMovement player;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.isKinematic = true;
        rolled = false;
 
       
    }


    void Update()
    { 
        if (body != null)
        {
        
            if (Input.GetKey(KeyCode.LeftShift))
            {
                RollDice();
                rolled = true;
                Debug.Log(rolled);
            }

            if (body.IsSleeping() && rolled)
                {
                SideValue();
                player.steps = DiceSideNum;
                    rolled = false;
                Debug.Log(rolled);
            }
            }
        
  
    }

    public void RollDice()
    {
            body.isKinematic = false;
            forceX = Random.Range(0, maxRandomForceValue);
            forceY = Random.Range(0, maxRandomForceValue);
            forceZ = Random.Range(0, maxRandomForceValue);
            body.AddForce(Vector3.up * startForce);
            body.AddTorque(forceX, forceY, forceZ);
      
            
    }


    void SideValue()
    {

        DiceSideNum = 0;
        foreach (DiceSide diceSide in diceSides)
        {
            if (diceSide.OnBoard())
            {
  
                    DiceSideNum = diceSide.sideValue;
            
            }
        }
    }
}
