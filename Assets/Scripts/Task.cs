using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Task1 : MonoBehaviour
{
    public bool collected = false;
    public PlayerMovement player;
    public Health health;
    public GameObject window;


    void OnTriggerEnter(Collider other)
    {
        if (collected) return;
        else 
        {
            collected = true;
            window.SetActive(true);
            gameObject.SetActive(false);

            Debug.Log("collected");
        }
    }
}
