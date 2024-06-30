using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondController : MonoBehaviour
{
    [Tooltip("Frames per second at which diamonds are animated.")]
 
    public float frameRate = 6;
    [Tooltip("Instances of diamonds which are animated. If empty, diamond instances are found and loaded at runtime.")]
    public Diamond[] diamonds;

    float nextFrameTime = 0;

    [ContextMenu("Find All diamonds")]
    void FindAlldiamondsInScene()
    {
        diamonds = Object.FindObjectsOfType<Diamond>();
    }

    void Awake()
    {
        if (diamonds.Length == 0)
            FindAlldiamondsInScene();
  
        for (var i = 0; i < diamonds.Length; i++)
        {
            diamonds[i].diamondIndex = i;
            diamonds[i].controller = this;
        }
    }

    void Update()
    {
    
        if (Time.time - nextFrameTime > (1f / frameRate))
        {
          
            for (var i = 0; i < diamonds.Length; i++)
            {
                var diamond = diamonds[i];
             
                if (diamond != null)
                {
                    diamond._renderer.sprite = diamond.sprites[diamond.frame];
                    if (diamond.collected && diamond.frame == diamond.sprites.Length - 1)
                    {
                        diamond.gameObject.SetActive(false);
                        diamonds[i] = null;
                    }
                    else
                    {
                        diamond.frame = (diamond.frame + 1) % diamond.sprites.Length;
                    }
                }
            }
            nextFrameTime += 1f / frameRate;
        }
    }

}

