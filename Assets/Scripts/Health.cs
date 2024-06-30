using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
 
    /// The maximum hit points for the entity.
    public int maxHP = 3;
    public Text text;
    public Diamond diamond;

    private bool IsAlive => currentHP > 0;

    private int currentHP;

    public void Increment()
    {
        currentHP = currentHP + 1;
    }

  
    public void Decrement()
    {
        currentHP = currentHP - 1;
        if (currentHP == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }

   
    public void Die()
    {
        while (currentHP > 0)
        {
            Decrement();
        }
    }

    void Awake()
    {
        currentHP = maxHP;
        text.text = "Health = " + currentHP.ToString();
    }
    
    void Update()
    {
        text.text = "Health = " + currentHP.ToString();

    }
}
