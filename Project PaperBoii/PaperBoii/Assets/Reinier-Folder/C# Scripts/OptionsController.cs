using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{

    public Slider volumeSlider;
    public Slider brightnessSlider;
    public SceneManager sceneManager;

    private MusicManager musicManager;

    // Start is called before the first frame update
    void Start()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        brightnessSlider.value = PlayerPrefsManager.GetMasterBrightness();
    }

    private void Update()
    {
        musicManager.ChangeVolume(volumeSlider.value);
        
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetMasterBrightness(brightnessSlider.value);
        SceneManager.Instance.LoadStartScene();
    }
}
