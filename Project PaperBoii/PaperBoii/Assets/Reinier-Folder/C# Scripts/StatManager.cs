using UnityEngine;
using TMPro;

public class StatManager : MonoBehaviour
{
    [SerializeField] GameObject deathPanel;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI timeTextPanel;
    [SerializeField] float moneyAmount = 0;
    [SerializeField] int paperAmount = 0;
    [SerializeField] float playTime = 0;
    int minutes = 0;

    private static StatManager instance;
    public static StatManager Instance { get => instance; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
            Destroy(this);
    }

    private void Start()
    {
        EventManager.current.onPlayerDie += Death;
        Debug.Log("Instancie");
    }

    public void Death()
    {
        Debug.Log("death");
        deathPanel.SetActive(true);
        Time.timeScale = 0;
    }

    private void Update()
    {
        playTime += Time.deltaTime;
        if (playTime > 59.5f)
        {
            playTime = -0.6f;
            minutes += 1;
        }
        string playTimeString = string.Format("{00:00}", playTime);
        timeText.text = "Playtime: " + minutes + ":" + playTimeString;
        timeTextPanel.text = "Playtime: " + minutes + ":" + playTimeString;
    }
}
