using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenuCanvas;
    public bool IsPaused;

    void Start()
    {
        PauseMenuCanvas.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                pause();
            }
        }
    }
    public void pause()
    {
        PauseMenuCanvas.SetActive(true);
        Time.timeScale = 0;
        IsPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Resume()
    {
        PauseMenuCanvas.SetActive(false);
        Time.timeScale = 1;
        IsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title Screen");
        IsPaused = false;
    }
}
