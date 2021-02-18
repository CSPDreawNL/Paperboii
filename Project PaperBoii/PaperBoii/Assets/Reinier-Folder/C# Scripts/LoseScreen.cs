using UnityEngine;

public class LoseScreen : MonoBehaviour
{
    public void MainMenuButton()
    {
        SceneManager.Instance.LoadStartScene();
    }
    public void RestartButton()
    {
        SceneManager.Instance.ReloadScene();
        Time.timeScale = 1;
    }
}
