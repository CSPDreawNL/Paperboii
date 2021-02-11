using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.Instance.LoadNextScene();
    }
    public void QuitButton()
    {
        SceneManager.Instance.QuitRequest();
    }
}
