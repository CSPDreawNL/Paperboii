using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.Instance.LoadScene("Bo-TestScene");
    }
    public void QuitButton()
    {
        SceneManager.Instance.QuitRequest();
    }
    public void OptionsButton()
    {
        SceneManager.Instance.LoadScene("ReinierOptionsScreen");
    }
}
