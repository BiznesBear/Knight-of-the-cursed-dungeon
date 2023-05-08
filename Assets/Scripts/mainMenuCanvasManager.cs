using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuCanvasManager : MonoBehaviour
{
    //canvas
    public void LoadGame()
    {
        SceneManager.LoadScene("camp");
    }
    public void setActiveTrue(GameObject Object)
    {
        Object.SetActive(true);
    }
    public void setActiveFalse(GameObject Object)
    {
        Object.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    //social

    public void DiscordBtn()
    {
        Application.OpenURL("https://discord.gg/nMwTJ39N");
    }
}
