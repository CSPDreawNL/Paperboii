using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.Instance.LoadScene("Level");
    }
    public void QuitButton()
    {
        SceneManager.Instance.QuitRequest();
    }
    public void OptionsButton()
    {
        SceneManager.Instance.LoadScene("ReinierOptionsScreen");
    }
    public void BackButton()
    {
        SceneManager.Instance.LoadStartScene();
    }
}
