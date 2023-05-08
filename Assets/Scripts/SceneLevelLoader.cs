using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transisionTime=1;
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transisionTime);
        SceneManager.LoadScene(levelIndex);
    }
    public void LoadNextLevel(int level)
    {
        StartCoroutine(LoadLevel(level));
    }
}
