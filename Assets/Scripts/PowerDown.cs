using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class PowerDown : MonoBehaviour
{
    public bool collected = false;
    public PlayerMovement player;
    public Health health;
    void OnTriggerEnter(Collider other)
    {
        if (collected) return;
        else 
        {
            collected = true;
            health.Decrement();
            gameObject.SetActive(false);

            Debug.Log("collected");
        }
    }

}
