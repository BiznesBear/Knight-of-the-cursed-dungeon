using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DungeonEndRoom : MonoBehaviour
{
    private SceneLevelLoader levelLoader;
    public bool floorReset= false;
    private void Start()
    {
        levelLoader = GameObject.FindGameObjectWithTag("LevelLoader").GetComponent<SceneLevelLoader>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("player"))
        {
            PlayerPrefs.SetInt("floor",0);
            levelLoader.LoadNextLevel(2);
            if (floorReset)
                PlayerPrefs.SetInt("floor", 0);
        }
    }
}
