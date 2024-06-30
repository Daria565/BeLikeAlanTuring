using UnityEngine;

public class Diamond : MonoBehaviour
{
    public AudioClip tokenCollectAudio;
    [Tooltip("If true, animation will start at a random position in the sequence.")]
    public bool randomAnimationStartTime = false;
    [Tooltip("List of frames that make up the animation.")]
    public Sprite[] idleAnimation, collectedAnimation;

    internal Sprite[] sprites = new Sprite[0];

    internal SpriteRenderer _renderer;

   
    internal int diamondIndex = -1;
    internal DiamondController controller;
   
    public int frame = 0;
    public bool collected = false;
    public PlayerMovement player;
    public Health health;

    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();

        if (randomAnimationStartTime)
            frame = Random.Range(0, sprites.Length);
        sprites = idleAnimation;
    }

    void OnTriggerEnter(Collider other)
    {
        if (collected) return;
        //disable the gameObject and remove it from the controller update list.
        frame = 0;
        sprites = collectedAnimation;
        if (controller != null) { 
        collected = true;
            health.Increment();

        Debug.Log("collected"); }
 
    }

}
