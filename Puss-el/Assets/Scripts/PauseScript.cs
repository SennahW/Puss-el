using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour

{
    public bool isPaused;
    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }

    public void ActivateMenu()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void DeactivateMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ToLevelSelect()
    {
        SceneManager.LoadScene(5);
    }

    public void Resume()
    {
        isPaused = !isPaused;
    }
}
