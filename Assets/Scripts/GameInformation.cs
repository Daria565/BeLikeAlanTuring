using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInformation : MonoBehaviour
{
    public bool paused = false;
    public GameObject gameInfromation;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("esc");
            if (paused)
            {
                Debug.Log("pause");
                Play();
            }
            else
            {
                Stop();
            }
        }
    }

    void Stop()
    {
        gameInfromation.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void Play()
    {
        gameInfromation.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    public void Return()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
