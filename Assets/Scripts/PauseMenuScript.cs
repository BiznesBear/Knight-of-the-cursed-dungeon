using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public static bool gamePause;
    private PlayerStats playerStats;
    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!gamePause)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }
    public void Resume()
    {
        gamePause = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void Pause()
    {
        gamePause = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ExitDungeon()
    {
        SceneManager.LoadScene("camp");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void OpenMenu(GameObject openMenu)
    {
        openMenu.SetActive(true);
        
    }
    public void CloseMenu(GameObject closeMenu)
    {
        closeMenu.SetActive(false);
    }
    public void Save()
    {
        PlayerPrefs.Save();
    }

}
