using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private static SceneManager instance;
    public static SceneManager Instance { get => instance; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
            Destroy(this);
    }

    public void LoadStartScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void ReloadScene()
    {
        int currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadScene(string name)
    {
        Debug.Log("Level load requested for: " + name);
        UnityEngine.SceneManagement.SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Application.Quit();
    }

}
